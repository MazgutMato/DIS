using DIS.Distributions;
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
        public bool _stopSimulation { get; set; }
        public int _ignore { get; set; }
        public Dictionary<string, Distribution>? _generators;
        public Dictionary<string, Statistic> _globalStatistics;
        public event EventHandler _dataUpdate;
        protected SimulationCore(int repCount)
        {
            _totalRepCount = repCount;
            _actualRepCount = 0;
            _dataGenerate = 1000;
            _ignore = 30;
            _stopSimulation = false;
            _globalStatistics = new Dictionary<string, Statistic>();
        }
        protected virtual void OnDataUpdate(EventArgs e)
        {
            _dataUpdate?.Invoke(this, e);
        }
        public void RunSimulation()
        {
            BeforeSimulation();
            while(_actualRepCount < _totalRepCount && !_stopSimulation)
            {
                BeforeRep();
                RepBody();
                AfterRep();
            }
            AfterSimulation();
        }
        protected abstract void RepBody();
        protected virtual void BeforeSimulation() {
            _actualRepCount = 0;
            _stopSimulation = false;
        }
        protected virtual void AfterSimulation() {}
        protected virtual void BeforeRep() { }
        protected virtual void AfterRep() {
            _actualRepCount++;

            if (!_stopSimulation)
            {
                this.OnDataUpdate(EventArgs.Empty);
            }
        }
     
    }
}
