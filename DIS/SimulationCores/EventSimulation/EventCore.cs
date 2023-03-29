using DIS.Models.NewsSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.EventSimulation
{
    public enum Mode
    {
        NORMAL = 0,
        TURBO = 1,
    }
    public abstract class EventCore : SimulationCore
    {
        private PriorityQueue<Event, double> _eventQueue;
        public double _actualTime { get; set; }
        public double _maxTime { get; }
        public double _speed { get; set; }
        public double _sleepTime { get; set; }
        public Mode _mode { get; set; }
        public EventCore(int repCount, double maxTime) : base(repCount)
        {
            _eventQueue = new PriorityQueue<Event, double>();
            _localStatistic = new Dictionary<string, Statistic>();
            _actualTime = 0;
            _maxTime = maxTime;
            _speed = 1;
            _sleepTime = 1000;
            _mode = Mode.NORMAL;
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            _eventQueue = new PriorityQueue<Event, double>();
            _localStatistic = new Dictionary<string, Statistic>();
            AddEvent(new SystemEvent(0, this));
            _actualTime = 0;
        }

        protected override void RepBody()
        {
            while (_actualTime <= _maxTime && _eventQueue.Count > 0 && !_stopSimulation)
            {
                while (_pause)
                {
                    if (_stopSimulation)
                    {
                        return;
                    }
                    Thread.Sleep(100);
                }
                var actualEvent = _eventQueue.Dequeue();

                if (actualEvent._eventTime < _maxTime)
                {
                    actualEvent.Execute();
                }
            }
        }

        public void AddEvent(Event addedEvent)
        {
            if (addedEvent != null && addedEvent._eventTime >= 0)
            {
                _eventQueue.Enqueue(addedEvent, addedEvent._eventTime);
                return;
            }
            throw new Exception("Cannot add event!");
        }
    }
}
