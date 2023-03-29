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
        public Vehicle _vehicle { get; set; }
        public STKEvent(double eventTime, EventCore core, Vehicle vehicle) : base(eventTime, core)
        {
            _vehicle = vehicle;
        }
    }
}
