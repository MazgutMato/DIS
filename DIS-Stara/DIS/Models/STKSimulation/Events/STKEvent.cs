using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class STKEvent : Event
    {
        public Worker _worker { get; set; }        
        public STKEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core)
        {            
            _worker = worker;
        }
    }
}
