using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using DIS.Models.NewsSimulation.Events;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.NewsSimulation.Events
{
    public class ArrivalEvent : NewsEvent
    {
        public ArrivalEvent(double eventTime, EventCore core, Customer customer) : base(eventTime, core, customer)
        {
        }

        public override void Execute()
        {
            base.Execute();
            var core = (NewsStand)_myCore;

            //Arivaval next customer
            if (core._generators.TryGetValue("customers", out Distribution distribution))
            {
                var nextArrival = distribution.Next();
                var nextCustomer = new Customer(core._actualTime + nextArrival);
                core.AddEvent(new ArrivalEvent(core._actualTime + nextArrival, core, nextCustomer));

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
