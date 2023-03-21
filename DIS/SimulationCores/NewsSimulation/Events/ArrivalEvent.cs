using DIS.SimulationCores.SimulationEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.NewsSimulation.Events
{
    public class ArrivalEvent : NewsEvent
    {
        public ArrivalEvent(double eventTime, EventCore core, Customer customer) : base(eventTime, core, customer)
        {
        }

        public override void Execute()
        {
            base.Execute();

            var core = ((NewsStand)_myCore);
            core._working = true;
            core._totalWaitingTime = core._actualTime - _customer._arrivalTime;

            core.AddEvent(new StartEvent(core._actualTime, core, _customer));
        }
    }
}
