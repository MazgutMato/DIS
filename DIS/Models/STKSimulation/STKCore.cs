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
        public PriorityQueue<Vehicle, double> _vehicleLine { get; }
        public STKCore(int repCount, double maxTime) : base(repCount, maxTime)
        {
            this._vehicleLine = new PriorityQueue<Vehicle, double>();         
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            this._generators = new Dictionary<string, Distribution>();
            this._generators.Add("arrival", new Exponential(23));
            this._generators.Add("vehicleType", new ContinuosUniform(0,1));
        }
    }
}
