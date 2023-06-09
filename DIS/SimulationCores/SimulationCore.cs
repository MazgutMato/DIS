﻿using DIS.Distributions;
using DIS.SimulationCores.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores
{
    public abstract class SimulationCore
    {
        public int _totalRepCount { get; }
        public int _actualRepCount { get; set; }
        public int _dataGenerate { get; set; }
        public bool _pause { get; set; }
        public bool _stopSimulation { get; set; }
        public int _ignore { get; set; }
        public event EventHandler _dataUpdate;
        protected SimulationCore(int repCount)
        {
            _totalRepCount = repCount;
            _dataGenerate = 1000;
            _ignore = 30;
            _actualRepCount = 0;
            _stopSimulation = false;
            _pause = false;
        }
        protected virtual void BeforeSimulation()
        {
            _actualRepCount = 0;
            _stopSimulation = false;
        }
        protected virtual void BeforeRep() { }
        public void RunSimulation()
        {
            BeforeSimulation();
            while (_actualRepCount < _totalRepCount && !_stopSimulation)
            {
                BeforeRep();
                RepBody();
                AfterRep();
            }
            AfterSimulation();
        }
        protected abstract void RepBody();
        protected virtual void AfterRep()
        {
            _actualRepCount++;

            if (!_stopSimulation && (_actualRepCount % _dataGenerate == 0))
            {
                this.OnDataUpdate(EventArgs.Empty);
            }
        }
        protected virtual void AfterSimulation()
        {
            this.OnDataUpdate(EventArgs.Empty);
        }
        public void OnDataUpdate(EventArgs e)
        {
            _dataUpdate?.Invoke(this, e);
        }
    }
}
