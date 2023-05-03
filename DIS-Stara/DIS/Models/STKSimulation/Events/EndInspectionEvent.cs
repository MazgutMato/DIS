using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class EndInspectionEvent : STKEvent
    {
        public EndInspectionEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }

        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;

            //Start payment
            if(core._technicWorkers.Count > 0)
            {
                //Statistic
                core._freeTechnicalLocal.AddValue(core._technicWorkers.Count);
                //Code
                var paymentWorker = core._technicWorkers.Dequeue();
                if(core._paymentParking.Count > 0)
                {
                    paymentWorker._vehicle = core._paymentParking.Dequeue();
                    core._paymentParking.Enqueue(_worker._vehicle);
                }
                else
                {
                    paymentWorker._vehicle = _worker._vehicle;
                    core.AddEvent(new StartPaymentEvent(core._actualTime, core, paymentWorker));
                }
            }
            else
            {
                core._paymentParking.Enqueue(_worker._vehicle);
            }

            //Start inspection
            _worker._vehicle = null;
            //Statisitc
            core._freeInspectionLocal.AddValue(core._inspectionWorkers.Count);
            if (core._inspectionParking.Count > 0)
            {
                _worker._vehicle = core._inspectionParking.Dequeue();
                core.AddEvent(new StartInspectionEvent(_eventTime, core, _worker));
            } else
            {                               
                core._inspectionWorkers.Enqueue(_worker);
            }

            //Set working type
            _worker._working = Working.NONE;
        }
    }
}
