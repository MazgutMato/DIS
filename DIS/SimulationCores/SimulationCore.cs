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
        public event EventHandler? _updateChart;
        public bool _stopSimulation { get; set; }
        public int _ignore { get; set; }
        protected SimulationCore(int repCount)
        {
            _totalRepCount = repCount;
            _actualRepCount = 0;
            _dataGenerate = 1000;
            _ignore = 30;
            _stopSimulation = false;
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
        public abstract double GetResult();
        protected virtual void BeforeSimulation() {
            _actualRepCount = 0;
            _stopSimulation = false;
        }
        protected virtual void AfterSimulation() {
            _updateChart?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void BeforeRep() { }
        protected virtual void AfterRep() {
            _actualRepCount++;

            if(_actualRepCount % (_totalRepCount / _dataGenerate) == 0 && (_actualRepCount / (double)_totalRepCount * 100) > _ignore)
            {
                _updateChart?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
