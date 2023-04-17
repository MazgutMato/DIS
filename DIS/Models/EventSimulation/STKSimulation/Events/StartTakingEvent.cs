using DIS.Distributions;
using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.EventSimulation.STKSimulation.Events
{
    public class StartTakingEvent : STKEvent
    {
        public StartTakingEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;

            //Statistic
            core._waitingTimeLocal.AddValue(_myCore._actualTime - _worker._vehicle._arrivalTime);

            //Set working type
            _worker._working = Working.TAKING;

            //End taking event            
            var endOfTaking = core._takingTime.Next();
            _myCore.AddEvent(new EndTakingEvent(_myCore._actualTime + endOfTaking, _myCore, _worker));
        }
    }
}
