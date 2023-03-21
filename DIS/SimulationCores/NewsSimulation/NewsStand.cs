using DIS.Distributions;
using DIS.SimulationCores.NewsSimulation.Events;
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
        public Dictionary<string, Distribution>? _generators;
        public bool _working { get; set; }
        public PriorityQueue<Customer, double>? _waitingCustomers;
        public double _totalWaitingTime;
        public NewsStand(int repCount, double maxTime) : base(repCount, maxTime)
        {
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            _working = false;
            _totalWaitingTime = 0;

            _generators = new Dictionary<string, Distribution>();
            _generators.Add("customers", new Exponential(5));
            _generators.Add("service", new Exponential(4));

            _waitingCustomers = new PriorityQueue<Customer, double>();

            if (_generators.TryGetValue("customers", out Distribution distribution))
            {
                var firstArrival = distribution.Next();
                var firstCustomer = new Customer(firstArrival);
                this.AddEvent(new ArrivalEvent(firstArrival, this, firstCustomer));
            }
            else
            {
                throw new Exception("Distribution doesnt exists!");
            }
        }

        public override double GetResult()
        {
            throw new NotImplementedException();
        }

    }
}
