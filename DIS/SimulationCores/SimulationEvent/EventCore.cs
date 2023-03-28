using DIS.SimulationCores.NewsSimulation;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.SimulationEvent
{
    public enum Mode
    {
        NORMAL = 0,
        TURBO = 1,
    }
    public abstract class EventCore : SimulationCore
    {
        private PriorityQueue<Event, double> _eventQueue;
        public Dictionary<string, Statistic> _localStatistic { get; set; }
        public double _actualTime { get; set; }
        public double _maxTime { get; }
        public double _speed { get; set; }
        public double _sleepTime { get; set; }
        public Mode _mode { get; set; }
        public bool _pause { get; set; }
        public EventCore(int repCount, double maxTime) : base(repCount)
        {
            this._eventQueue = new PriorityQueue<Event,double>();
            this._localStatistic = new Dictionary<string, Statistic>();
            this._actualTime = 0;
            this._maxTime = maxTime;
            this._speed = 1;
            this._sleepTime = 0.1;
            this._mode = Mode.NORMAL;
            this._pause = false;
        }

        protected override void BeforeRep()
        {
            base.BeforeRep();

            this._eventQueue = new PriorityQueue<Event, double>();
            this._localStatistic = new Dictionary<string, Statistic>();
            this.AddEvent(new SystemEvent(0, this));
            this._actualTime = 0;
        }

        protected override void RepBody()
        {
            while (_actualTime < _maxTime && _eventQueue.Count > 0 && !_stopSimulation)
            {
                while (_pause)
                {
                    Thread.Sleep(500);
                }
                var actualEvent = _eventQueue.Dequeue();

                if (actualEvent._eventTime < _maxTime)
                {
                    actualEvent.Execute();
                }
            }
        }

        protected override void AfterRep()
        {
            base.AfterRep();

            if (!_stopSimulation)
            {
                foreach(var stat in _localStatistic)
                {
                    if (_globalStatistics.TryGetValue(stat.Key, out Statistic statistic))
                    {
                        var normalStatistic = (NormalStatistic)statistic;
                        normalStatistic.AddValue(stat.Value.GetResult());
                    }
                    else
                    {
                        var newStat = new NormalStatistic();
                        newStat.AddValue(stat.Value.GetResult());
                        _globalStatistics.Add(stat.Key, newStat);   
                    }
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
