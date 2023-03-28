using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.SimulationEvent
{
    public class SystemEvent : Event
    {
        public SystemEvent(double eventTime, EventCore core) : base(eventTime, core)
        {
        }

        public override void Execute()
        {
            base.Execute();

            Thread.Sleep(500);

            _myCore.AddEvent(new SystemEvent(_eventTime + _myCore._speed, _myCore));
        }
    }
}
