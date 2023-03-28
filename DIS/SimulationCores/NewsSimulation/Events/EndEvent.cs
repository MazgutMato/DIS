using DIS.SimulationCores.SimulationEvent;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.NewsSimulation.Events
{
    public class EndEvent : NewsEvent
    {
        public EndEvent(double eventTime, EventCore core, Customer customer) : base(eventTime, core, customer)
        {
        }

        public override void Execute()
        {
            base.Execute();

            var core = ((NewsStand)_myCore);

            if(core._waitingCustomers.Count > 0)
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
                var nextCustomer = core._waitingCustomers.Dequeue();

                core.AddEvent(new StartEvent(core._actualTime, core, nextCustomer));
            }
            else
            {
                core._working = false;
            }
        }
    }
}
