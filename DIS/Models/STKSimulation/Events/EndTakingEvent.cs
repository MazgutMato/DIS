using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class EndTakingEvent : STKEvent
    {
        public EndTakingEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;

            //Decrease takeCars            
            core._takeCarsCount--;

            //StartInspection
            if (core._inspectionWorkers.Count > 0)
            {
                var inspectionWorker = core._inspectionWorkers.Dequeue();
                if (core._inspectionParking.Count > 0)
                {
                    var inspectionVehilce = _worker._vehicle;
                    inspectionWorker._vehicle = inspectionVehilce;                    
                }
                else
                {
                    var inspectionVehilce = core._inspectionParking.Dequeue();
                    inspectionWorker._vehicle = inspectionVehilce;
                    core._inspectionParking.Enqueue(_worker._vehicle);
                }
                core.AddEvent(new StartInspectionEvent(core._actualTime, core, inspectionWorker));
            }
            else
            {
                core._inspectionParking.Enqueue(_worker._vehicle);
            }

            //Start payment
            if(core._paymentParking.Count > 0)
            {
                var paymentVehicle = core._paymentParking.Dequeue();
                var paymentWorker = _worker;
                paymentWorker._vehicle = paymentVehicle;
                core.AddEvent(new StartPaymentEvent(core._actualTime, core, paymentWorker));
            } else
            {
                //Start new taking
                if(core._vehicleLine.Count > 0 && core._inspectionParking.Count + core._takeCarsCount 
                    < core._inspectionParkingCapacity)
                {
                    _worker._vehicle = core._vehicleLine.Dequeue();
                    core._takeCarsCount++;
                    core.AddEvent(new StartTakingEvent(_eventTime, core, _worker));
                }else
                {
                    _worker._vehicle = null;
                    core._technicWorkers.Enqueue(_worker);
                }
            }            

        }
    }
}
