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

            var core = (STKCore)_myCore;

            //Set working type
            _worker._working = Working.PAYMENT;

            //End of payment            
            var endOfPayment = core._paymentTime.Next();

            _myCore.AddEvent(new EndPaymentEvent(_myCore._actualTime + endOfPayment, _myCore, _worker));
        }
    }
}
