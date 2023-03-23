using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.SimulationEvent
{
    public abstract class EventCore : SimulationCore
    {
        private PriorityQueue<Event, double> _eventQueue;
        public double _actualTime { get; set; }
        public double _maxTime { get; }

        public EventCore(int repCount, double maxTime) : base(repCount)
        {
            this._eventQueue = new PriorityQueue<Event,double>();
            this._actualTime = 0;
            this._maxTime = maxTime;
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            this._eventQueue = new PriorityQueue<Event, double>();
            this._actualTime = 0;
        }

        protected override void RepBody()
        {
            while (_actualTime < _maxTime && _eventQueue.Count > 0)
            {
                var actualEvent = _eventQueue.Dequeue();

                if (actualEvent._eventTime < _maxTime)
                {
                    actualEvent.Execute();
                }
            }
        }        

        public bool AddEvent(Event addedEvent){
            if(addedEvent != null && addedEvent._eventTime > 0)
            {
                _eventQueue.Enqueue(addedEvent, addedEvent._eventTime); 
                return true;
            }
            return false;
        }
    }
}
