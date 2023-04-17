using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.EventSimulation.STKSimulation
{
    public class STKCore : EventCore
    {
        public Queue<Vehicle> _vehicleLine { get; set; }
        public Queue<Vehicle> _paymentParking { get; set; }
        public Queue<Vehicle> _inspectionParking { get; set; }
        public int _inspectionParkingCapacity { get; }
        public int _takeCarsCount { get; set; }
        public Queue<Worker> _inspectionWorkers { get; set; }
        public int _inspectionWorkersCount { get; set; }
        public Queue<Worker> _technicWorkers { get; set; }
        public List<Worker> _workers { get; set; }
        public int _technicWorkersCount { get; set; }
        public int _totalVehicleCount { get; set; }
        public int _actualCarsInSystem { get; set; }
        public Exponential _arrival { get; set; }
        public ContinuosUniform _vehicleType { get; set; }
        public TriangularDistribution _takingTime { get; set; }
        public TriangularDistribution _ending { get; set; }
        public ContinuosUniform _paymentTime { get; set; }
        public DiscreteUniform _inspectionCar { get; set; }
        public DiscreteEmpirical _inspectionVan { get; set; }
        public DiscreteEmpirical _inspectionTruck { get; set; }
        public NormalStatistic _timeInSystemLocal { get; set; }
        public NormalStatistic _waitingTimeLocal { get; set; }
        public NormalStatistic _timeInSystemGlobal { get; set; }
        public NormalStatistic _waitingTimeGlobal { get; set; }
        public WeightStatistic _vehicleInSystemLocal { get; set; }
        public NormalStatistic _vehicleInSystemGlobal { get; set; }
        public WeightStatistic _lineLengthLocal { get; set; }
        public NormalStatistic _lineLengthGlobal { get; set; }
        public WeightStatistic _freeTechnicalLocal { get; set; }
        public WeightStatistic _freeInspectionLocal { get; set; }
        public NormalStatistic _freeTechnicalGlobal { get; set; }
        public NormalStatistic _freeInspectionGlobal { get; set; }
        public NormalStatistic _vehiclesAtTheEnd { get; set; }
        public int _endingVehicles { get; set; }
        public STKCore(int repCount, double maxTime) : base(repCount, maxTime)
        {
            _vehicleLine = new Queue<Vehicle>();
            _paymentParking = new Queue<Vehicle>();
            _inspectionParkingCapacity = 5;
            _inspectionParking = new Queue<Vehicle>(_inspectionParkingCapacity);
            _technicWorkers = new Queue<Worker>();
            _inspectionWorkers = new Queue<Worker>();
            _takeCarsCount = 0;
            _technicWorkersCount = 1;
            _inspectionWorkersCount = 1;
            _totalVehicleCount = 0;
            _actualCarsInSystem = 0;
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            _vehicleLine = new Queue<Vehicle>();
            _paymentParking = new Queue<Vehicle>();
            _inspectionParking = new Queue<Vehicle>(_inspectionParkingCapacity);
            _technicWorkers = new Queue<Worker>();
            for (int i = 0; i < _technicWorkersCount; i++)
            {
                _technicWorkers.Enqueue(new Worker(i + 1, WorkerType.TECHNICAL));
            }
            _inspectionWorkers = new Queue<Worker>();
            for (int i = 0; i < _inspectionWorkersCount; i++)
            {
                _inspectionWorkers.Enqueue(new Worker(i + 1, WorkerType.INSPECTION));
            }
            _workers = new List<Worker>();
            _workers.AddRange(_inspectionWorkers);
            _workers.AddRange(_technicWorkers);

            _takeCarsCount = 0;
            _totalVehicleCount = 0;
            _actualCarsInSystem = 0;

            //Arrival[0]
            _arrival = new Exponential((double)3600 / 23);
            //Vehicle type[1]
            _vehicleType = new ContinuosUniform(0, 1);
            //Taking time[2]
            _takingTime = new TriangularDistribution(180, 695, 431);
            //Payment time[3]
            _paymentTime = new ContinuosUniform(65, 177);
            //Ispection time in minutes car[4]
            _inspectionCar = new DiscreteUniform(31, 45);
            //Ispection time in minutes van[5]
            var vanParams = new List<EmpiricalParam>();
            vanParams.AddRange(new[] {
                new EmpiricalParam(35, 37, 0.2),
                new EmpiricalParam(38, 40, 0.35),
                new EmpiricalParam(41, 47, 0.3),
                new EmpiricalParam(48, 52, 0.15)
            });
            _inspectionVan = new DiscreteEmpirical(vanParams);
            //Ispection time in minutes truck[6]
            var truckParams = new List<EmpiricalParam>();
            truckParams.AddRange(new[] {
                new EmpiricalParam(37, 42, 0.05),
                new EmpiricalParam(43, 45, 0.1),
                new EmpiricalParam(46, 47, 0.15),
                new EmpiricalParam(48, 51, 0.4),
                new EmpiricalParam(52, 55, 0.25),
                new EmpiricalParam(56, 65, 0.05)
            });
            _inspectionTruck = new DiscreteEmpirical(truckParams);
            //Ending
            _endingVehicles = 0;
            _ending = new TriangularDistribution(10, 35, 30);


            //Statistics
            _timeInSystemLocal = new NormalStatistic();
            _waitingTimeLocal = new NormalStatistic();
            _lineLengthLocal = new WeightStatistic(this);
            _freeInspectionLocal = new WeightStatistic(this);
            _freeTechnicalLocal = new WeightStatistic(this);
            _vehicleInSystemLocal = new WeightStatistic(this);
        }

        protected override void BeforeSimulation()
        {
            base.BeforeSimulation();

            _timeInSystemGlobal = new NormalStatistic();
            _waitingTimeGlobal = new NormalStatistic();
            _lineLengthGlobal = new NormalStatistic();
            _freeTechnicalGlobal = new NormalStatistic();
            _freeInspectionGlobal = new NormalStatistic();
            _vehicleInSystemGlobal = new NormalStatistic();
            _vehiclesAtTheEnd = new NormalStatistic();
        }

        protected override void AfterRep()
        {
            base.AfterRep();

            if (!_stopSimulation)
            {
                _lineLengthLocal.AddValue(_vehicleLine.Count);
                _vehicleInSystemLocal.AddValue(_actualCarsInSystem);
                _freeTechnicalLocal.AddValue(_technicWorkers.Count);
                _freeInspectionLocal.AddValue(_inspectionWorkers.Count);

                _waitingTimeGlobal.AddValue(_waitingTimeLocal.GetResult());
                _timeInSystemGlobal.AddValue(_timeInSystemLocal.GetResult());
                _lineLengthGlobal.AddValue(_lineLengthLocal.GetResult());
                _freeInspectionGlobal.AddValue(_freeInspectionLocal.GetResult());
                _freeTechnicalGlobal.AddValue(_freeTechnicalLocal.GetResult());
                _vehicleInSystemGlobal.AddValue(_vehicleInSystemLocal.GetResult());
                _vehiclesAtTheEnd.AddValue(_actualCarsInSystem);
            }
        }
    }
}
