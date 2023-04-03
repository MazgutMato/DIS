using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class EndPaymentEvent : STKEvent
    {
        public EndPaymentEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;

            //Statistic
            core._timeInSystemLocal.AddValue(core._actualTime - _worker._vehicle._arrivalTime);
            core._actualCarsInSystem--;

            //Start of payment
            if(core._paymentParking.Count > 0)
            {
                var paymentVehicle = core._paymentParking.Dequeue();
                _worker._vehicle = paymentVehicle;
                core.AddEvent(new StartPaymentEvent(core._actualTime, core, _worker));
            } else
            {
                //Start new taking
                if (core._vehicleLine.Count > 0 && core._inspectionParking.Count + core._takeCarsCount
                    < core._inspectionParkingCapacity)
                {
                    _worker._vehicle = core._vehicleLine.Dequeue();
                    core._takeCarsCount++;
                    core.AddEvent(new StartTakingEvent(_eventTime, core, _worker));
                }
                else
                {
                    _worker._vehicle = null;
                    core._technicWorkers.Enqueue(_worker);
                }
            }

            //Set working type
            _worker._working = Working.NONE;
        }
    }
}
