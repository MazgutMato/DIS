﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.EventSimulation
{
    public abstract class Event
    {
        public double _eventTime { get; set; }
        public EventCore _myCore { get; set; }
        public Event(double eventTime, EventCore core)
        {
            _eventTime = eventTime;
            _myCore = core;
        }
        public virtual void Execute()
        {
            if (_myCore._actualTime > _eventTime)
            {
                if(this is SystemEvent)
                {
                    _eventTime = _myCore._actualTime;
                } else
                {
                    throw new Exception("Invalid event time!");
                }                
            }
            _myCore._actualTime = _eventTime;
            if (_myCore._mode == Mode.NORMAL )
            {
                _myCore.OnDataUpdate(EventArgs.Empty);
            }
        }
    }
}
