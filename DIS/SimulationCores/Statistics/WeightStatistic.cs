using DIS.SimulationCores.EventSimulation;
using OSPABA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.Statistics
{
    public class WeightStatistic : Statistic
    {
        private double _lastUpdate;
        private Simulation _core { get; set; }
        public WeightStatistic(Simulation core) : base()
        {
            _lastUpdate = 0.0;
            _core = core;
        }

        public override void AddValue(double value)
        {
            var weight = _core.CurrentTime - _lastUpdate;
            _lastUpdate = _core.CurrentTime;

            if (weight < 0)
            {
                throw new Exception("Negative weight value!");
            }

            _sum += value * weight;
            _sum2 += Math.Pow(value, 2) * weight;
            _count += weight;            
        }
    }
}
