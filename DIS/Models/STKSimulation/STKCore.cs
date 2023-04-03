using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation
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
        public ContinuosUniform _paymentTime { get; set; }
        public DiscreteUniform _inspectionCar { get; set; }
        public DiscreteEmpirical _inspectionVan { get; set; }
        public DiscreteEmpirical _inspectionTruck { get; set; }
        public NormalStatistic _timeInSystemLocal { get; set; }
        public NormalStatistic _waitingTimeLocal { get; set; }
        public NormalStatistic _timeInSystemGlobal { get; set; }
        public NormalStatistic _waitingTimeGlobal { get; set; }
        public NormalStatistic _totalVehicleGlobal { get; set; }
        public NormalStatistic _vehicleInSystemGlobal { get; set; }

        public STKCore(int repCount, double maxTime) : base(repCount, maxTime)
        {
            this._vehicleLine = new Queue<Vehicle>();    
            this._paymentParking = new Queue<Vehicle>();
            this._inspectionParkingCapacity = 5;
            this._inspectionParking = new Queue<Vehicle>(_inspectionParkingCapacity);
            this._technicWorkers = new Queue<Worker>();
            this._inspectionWorkers = new Queue<Worker>();
            this._takeCarsCount = 0;
            this._technicWorkersCount = 1;
            this._inspectionWorkersCount = 1;
            this._totalVehicleCount = 0;
            this._actualCarsInSystem = 0;
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            this._vehicleLine = new Queue<Vehicle>();
            this._paymentParking = new Queue<Vehicle>();
            this._inspectionParking = new Queue<Vehicle>(_inspectionParkingCapacity);
            this._technicWorkers = new Queue<Worker>();
            for (int i = 0; i < _technicWorkersCount; i++)
            {
                this._technicWorkers.Enqueue(new Worker(i+1, WorkerType.TECHNICAL));
            }
            this._inspectionWorkers = new Queue<Worker>();
            for (int i = 0; i < _inspectionWorkersCount; i++)
            {
                this._inspectionWorkers.Enqueue(new Worker(i+1, WorkerType.INSPECTION));
            }
            this._workers = new List<Worker>();
            this._workers.AddRange(this._inspectionWorkers);
            this._workers.AddRange(this._technicWorkers);

            this._takeCarsCount = 0;
            this._totalVehicleCount = 0;
            this._actualCarsInSystem = 0;

            //Arrival[0]
            this._arrival = new Exponential(((double)3600) / 23);
            //Vehicle type[1]
            this._vehicleType = new ContinuosUniform(0,1);
            //Taking time[2]
            this._takingTime = new TriangularDistribution(180,695,431);
            //Payment time[3]
            this._paymentTime = new ContinuosUniform(65,177);
            //Ispection time in minutes car[4]
            this._inspectionCar = new DiscreteUniform(31, 45);
            //Ispection time in minutes van[5]
            var vanParams = new List<EmpiricalParam>();
            vanParams.AddRange(new[] {
                new EmpiricalParam(35, 37, 0.2),
                new EmpiricalParam(38, 40, 0.35),
                new EmpiricalParam(41, 47, 0.3),
                new EmpiricalParam(48, 52, 0.15)
            });
            this._inspectionVan = new DiscreteEmpirical(vanParams);
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
            this._inspectionTruck = new DiscreteEmpirical(truckParams);

            //Statistics
            this._timeInSystemLocal = new NormalStatistic();            
            this._waitingTimeLocal = new NormalStatistic();            
        }

        protected override void BeforeSimulation()
        {
            base.BeforeSimulation();

            this._vehicleInSystemGlobal = new NormalStatistic();
            this._timeInSystemGlobal = new NormalStatistic();
            this._waitingTimeGlobal = new NormalStatistic();
            this._totalVehicleGlobal = new NormalStatistic();
        }

        protected override void AfterRep()
        {
            base.AfterRep();

            if (!_stopSimulation)
            {
                this._waitingTimeGlobal.AddValue(_waitingTimeLocal.GetResult());
                this._timeInSystemGlobal.AddValue(_timeInSystemLocal.GetResult());
                this._vehicleInSystemGlobal.AddValue(_actualCarsInSystem);
                this._totalVehicleGlobal.AddValue(_totalVehicleCount);
            }
        }
    }
}
