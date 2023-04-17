using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class EndEvent : Event
    {
        public EndEvent(double eventTime, EventCore core) : base(eventTime, core)
        {
        }

        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;
            core._endingVehicles--;
        }
    }
}
