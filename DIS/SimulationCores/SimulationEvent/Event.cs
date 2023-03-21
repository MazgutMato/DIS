using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.SimulationEvent
{
    public abstract class Event
    {
        public double _eventTime { get; set; }
        public EventCore _myCore { get; set; }
        public Event(double eventTime, EventCore core) { 
            _eventTime = eventTime;
            _myCore = core;
        }
        public abstract void Execute();
    }
}
