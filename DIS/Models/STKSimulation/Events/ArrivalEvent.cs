using DIS.Distributions;
using DIS.Models.NewsSimulation.Events;
using DIS.Models.NewsSimulation;
using DIS.SimulationCores.EventSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class ArrivalEvent : STKEvent
    {
        public ArrivalEvent(double eventTime, EventCore core, Vehicle vehicle) : base(eventTime, core, vehicle)
        {
        }

        public override void Execute()
        {
            base.Execute();

            base.Execute();
            var core = (STKCore)_myCore;

            //Arivaval next customer
            if (core._generators.TryGetValue("arrival", out Distribution distributionArrival))
            {
                var nextArrival = distributionArrival.Next();
                var nextVehicle = new Vehicle(nextArrival);

                if (core._generators.TryGetValue("vehicleType", out Distribution distributionType))
                {
                    var type = distributionType.Next();

                    if(type < 0.14)
                    {
                        nextVehicle._vehicleType = VehicleType.TRUCK;
                    } else if(type < 0.35)
                    {
                        nextVehicle._vehicleType = VehicleType.VAN;
                    }
                    else
                    {
                        nextVehicle._vehicleType = VehicleType.CAR;
                    }
                }
                else
                {
                    throw new Exception("Distribution doesnt exists!");
                }
                
                core.AddEvent(new ArrivalEvent(core._actualTime + nextArrival, core, nextVehicle));

                //Start of service
                if (core._working != true)
                {
                    core._working = true;
                    core.AddEvent(new StartEvent(core._actualTime, core, _customer));
                }
                else
                {
                    //Update line length
                    if (core._localStatistic.TryGetValue("lineLength", out Statistic statistic))
                    {
                        var weightStatistic = (WeightStatistic)statistic;
                        weightStatistic.AddValue(core._waitingCustomers.Count);
                    }
                    else
                    {
                        throw new Exception("Statistic doesnt exists!");
                    }
                    core._waitingCustomers.Enqueue(_customer, _customer._arrivalTime);
                }
            }
            else
            {
                throw new Exception("Distribution doesnt exists!");
            }
        }
    }
}
