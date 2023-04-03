using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.EventSimulation
{
    public class SystemEvent : Event
    {
        public SystemEvent(double eventTime, EventCore core) : base(eventTime, core)
        {
        }

        public override void Execute()
        {
            base.Execute();            

            if (_myCore._mode == Mode.NORMAL)
            {
                Thread.Sleep(Convert.ToInt32(_myCore._speed * 1000));                
            }
            _myCore.AddEvent(new SystemEvent(_eventTime + _myCore._refreshTime, _myCore));
        }
    }
}
