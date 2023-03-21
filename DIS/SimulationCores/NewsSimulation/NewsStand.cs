using DIS.Distributions;
using DIS.SimulationCores.SimulationEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.NewsSimulation
{
    public class NewsStand : EventCore
    {
        public Dictionary<string, Distribution> _generators;
        public bool _working { get; set; }
        public PriorityQueue<Customer, double> _waitingCustomers;
        public double _totalWaitingTime;
        public NewsStand(int repCount) : base(repCount)
        {
            _generators = new Dictionary<string, Distribution>();
            _generators.Add("customers", new Exponential(5));
            _generators.Add("service", new Exponential(4));

            _waitingCustomers = new PriorityQueue<Customer, double>();
        }

        public override double GetResult()
        {
            throw new NotImplementedException();
        }

        protected override void RepBody()
        {
            throw new NotImplementedException();
        }
    }
}
