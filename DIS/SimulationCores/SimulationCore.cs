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
        public bool _pause { get; set; }
        public bool _stopSimulation { get; set; }
        public int _ignore { get; set; }
        public Dictionary<string, Distribution>? _generators;
        public Dictionary<string, Statistic> _globalStatistics;
        public Dictionary<string, Statistic> _localStatistic { get; set; }
        public event EventHandler _dataUpdate;
        protected SimulationCore(int repCount)
        {
            _totalRepCount = repCount;
            _dataGenerate = 1000;
            _ignore = 30;
            _actualRepCount = 0;
            _stopSimulation = false;
            _globalStatistics = new Dictionary<string, Statistic>();
            _pause = false;
        }
        protected virtual void BeforeSimulation()
        {
            _actualRepCount = 0;
            _stopSimulation = false;
            _globalStatistics = new Dictionary<string, Statistic>();
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

            if (!_stopSimulation)
            {
                foreach (var stat in _localStatistic)
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
                //if (_actualRepCount % (_totalRepCount / _dataGenerate) == 0 &&
                //    (_actualRepCount / (double)_totalRepCount * 100) > _ignore)
                //{
                //    this.OnDataUpdate(EventArgs.Empty);
                //}
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
