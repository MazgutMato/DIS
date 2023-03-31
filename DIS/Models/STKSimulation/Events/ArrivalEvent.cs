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

            //Arivaval next customer
            if (core._generators.Count > 0)
            {
                var distributionArrival = core._generators[0];
                var nextArrival = distributionArrival.Next();                                
                
                core.AddEvent(new ArrivalEvent(core._actualTime + nextArrival, core));             
            }
            else
            {
                throw new Exception("Distribution doesnt exists!");
            }

            //Start of payment
            if (core._paymentParking.Count > 0 && core._technicWorkers.Count > 0)
            {
                var paymentVehicle = core._paymentParking.Dequeue();
                var paymentWorker = core._technicWorkers.Dequeue();
                paymentWorker._vehicle = paymentVehicle;
                core.AddEvent(new StartPaymentEvent(core._actualTime, core, paymentWorker));
            }

            //Arrival vehicle
            core._totalVehicleCount++;
            var arrivalVehicle = new Vehicle(core._totalVehicleCount, core._actualTime);
            //Set a type of vehicle
            if (core._generators.Count > 1)
            {
                var distributionType = core._generators[1];
                var type = distributionType.Next();

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
            }
            else
            {
                throw new Exception("Distribution doesnt exists!");
            }
            //Start taking
            if (core._technicWorkers.Count > 0 && core._takeCarsCount + core._inspectionParking.Count 
                < core._inspectionParkingCapacity)
            {
                core._takeCarsCount++;
                var takingWorker = core._technicWorkers.Dequeue();
                takingWorker._vehicle = arrivalVehicle;
                core.AddEvent(new StartTakingEvent(core._actualTime, core, takingWorker));
            }
            else
            {
                core._vehicleLine.Enqueue(arrivalVehicle);
            }
        }
    }
}
