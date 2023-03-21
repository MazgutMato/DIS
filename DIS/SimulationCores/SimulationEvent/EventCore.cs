using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.SimulationEvent
{
    public abstract class EventCore : SimulationCore
    {
        private PriorityQueue<Event,double> _priorityQueue;
        public double _actualTime { get; set; }

        public EventCore(int repCount) : base(repCount)
        {
            this._priorityQueue = new PriorityQueue<Event,double>();
            this._actualTime = 0;
        }

        protected void Simulate(double maxTime)
        {
            while (_actualTime < maxTime && _priorityQueue.Count > 0)
            {
                var actualEvent = _priorityQueue.Dequeue();
                _actualTime = actualEvent._eventTime;

                if (_actualTime < maxTime)
                {
                    actualEvent.Execute();
                }
            }
        }

        public bool AddEvent(Event addedEvent){
            if(addedEvent != null && addedEvent._eventTime > 0)
            {
                _priorityQueue.Enqueue(addedEvent, addedEvent._eventTime); 
                return true;
            }
            return false;
        }
    }
}
