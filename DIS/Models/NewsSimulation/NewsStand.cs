using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using DIS.Models.NewsSimulation.Events;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.NewsSimulation
{
    public class NewsStand : EventCore
    {
        public bool _working { get; set; }
        public PriorityQueue<Customer, double>? _waitingCustomers;
        public NewsStand(int repCount, double maxTime) : base(repCount, maxTime)
        {
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            _working = false;

            _localStatistic = new Dictionary<string, Statistic>();
            _localStatistic.Add("waitingTime", new NormalStatistic());
            _localStatistic.Add("lineLength", new WeightStatistic(this));

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
    }
}
