using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
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
        public int _technicWorkersCount { get; set; }
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
                this._technicWorkers.Enqueue(new Worker());
            }
            this._inspectionWorkers = new Queue<Worker>();
            for (int i = 0; i < _inspectionWorkersCount; i++)
            {
                this._inspectionWorkers.Enqueue(new Worker());
            }
            this._takeCarsCount = 0;

            this._generators = new Dictionary<string, Distribution>();
            this._generators.Add("arrival", new Exponential(23));
            this._generators.Add("vehicleType", new ContinuosUniform(0,1));
            this._generators.Add("takingTime", new TriangularDistribution(180,695,431));
        }
    }
}
