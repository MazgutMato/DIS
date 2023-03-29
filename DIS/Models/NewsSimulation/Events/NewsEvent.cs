using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.NewsSimulation.Events
{
    public abstract class NewsEvent : Event
    {
        public Customer _customer { get; set; }
        protected NewsEvent(double eventTime, EventCore core, Customer customer) : base(eventTime, core)
        {
            _customer = customer;
        }
    }
}
