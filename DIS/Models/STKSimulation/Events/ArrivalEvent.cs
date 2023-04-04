using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class ArrivalEvent : Event
    {
        public ArrivalEvent(double eventTime, EventCore core) : base(eventTime, core)
        {
        }

        public override void Execute()
        {
            base.Execute();
            var core = (STKCore)_myCore;

            //Statistic
            core._vehicleInSystemLocal.AddValue(core._actualCarsInSystem);
            core._actualCarsInSystem++;

            //Arivaval next customer            
            var nextArrival = core._arrival.Next();

            if ((core._actualTime + nextArrival) < 405 * 60)
            {
                core.AddEvent(new ArrivalEvent(core._actualTime + nextArrival, core));
            }

            //Start of payment
            if (core._paymentParking.Count > 0 && core._technicWorkers.Count > 0)
            {
                //Statistic
                core._freeTechnicalLocal.AddValue(core._technicWorkers.Count);
                //Code
                var paymentVehicle = core._paymentParking.Dequeue();
                var paymentWorker = core._technicWorkers.Dequeue();
                paymentWorker._vehicle = paymentVehicle;
                core.AddEvent(new StartPaymentEvent(core._actualTime, core, paymentWorker));
            }

            //Arrival vehicle
            core._totalVehicleCount++;
            var arrivalVehicle = new Vehicle(core._totalVehicleCount, core._actualTime);

            //Set a type of vehicle
            var type = core._vehicleType.Next();

            if (type < 0.14)
            {
                arrivalVehicle._vehicleType = VehicleType.TRUCK;
            }
            else if (type < 0.35)
            {
                arrivalVehicle._vehicleType = VehicleType.VAN;
            }
            else
            {
                arrivalVehicle._vehicleType = VehicleType.CAR;
            }

            //Start taking
            if (core._technicWorkers.Count > 0 && ((core._takeCarsCount + core._inspectionParking.Count) 
                < core._inspectionParkingCapacity))
            {
                //Statistic
                core._freeTechnicalLocal.AddValue(core._technicWorkers.Count);
                //Code
                core._takeCarsCount++;
                var takingWorker = core._technicWorkers.Dequeue();
                if (core._vehicleLine.Count > 0)
                {
                    //Statistic
                    core._lineLengthLocal.AddValue(core._vehicleLine.Count);
                    //Code
                    core._vehicleLine.Enqueue(arrivalVehicle);
                    takingWorker._vehicle = core._vehicleLine.Dequeue();
                }
                else
                {
                    takingWorker._vehicle = arrivalVehicle;                    
                }
                core.AddEvent(new StartTakingEvent(core._actualTime, core, takingWorker));
            }
            else
            {
                //Statistic
                core._lineLengthLocal.AddValue(core._vehicleLine.Count);
                core._vehicleLine.Enqueue(arrivalVehicle);
            }
        }
    }
}
