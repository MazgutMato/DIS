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
        public WeightStatistic() : base() { }

        public void AddValue(double value, double weight) { 
            _sum += value*weight;
            _count += weight;
        }
    }
}
