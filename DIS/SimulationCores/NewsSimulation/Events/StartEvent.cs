using DIS.Distributions;
using DIS.SimulationCores.SimulationEvent;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.NewsSimulation.Events
{
    public class StartEvent : NewsEvent
    {
        public StartEvent(double eventTime, EventCore core, Customer customer) : base(eventTime, core, customer)
        {
        }

        public override void Execute()
        {
            base.Execute();

            var core = ((NewsStand)_myCore);
            //Update waiting time
            if (core._localStatistic.TryGetValue("waitingTime", out Statistic statistic))
            {
                var normalStatistic = (NormalStatistic)statistic;
                normalStatistic.AddValue(core._actualTime - _customer._arrivalTime);
            }
            else
            {
                throw new Exception("Statistic doesnt exists!");
            }
            //End of service
            if (core._generators.TryGetValue("service", out Distribution distribution))
            {
                var endTime = distribution.Next();                
                core.AddEvent(new EndEvent(core._actualTime + endTime, core, _customer));
            }
            else
            {
                throw new Exception("Generator doesnt exists!");
            }
        }
    }
}
