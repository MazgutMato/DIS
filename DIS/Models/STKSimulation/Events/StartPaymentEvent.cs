using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class StartPaymentEvent : STKEvent
    {
        public StartPaymentEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();
        }
    }
}
