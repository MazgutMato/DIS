using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class StartTakingEvent : STKEvent
    {
        public StartTakingEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();

            //End taking event
            if (_myCore._generators.TryGetValue("takingTime", out Distribution distributionArrival))
            {
                var endOfTaking = distributionArrival.Next();

                _myCore.AddEvent(new EndTakingEvent(_myCore._actualTime + endOfTaking, _myCore, _worker));
            }
            else
            {
                throw new Exception("Distribution doesnt exists!");
            }            
        }
    }
}
