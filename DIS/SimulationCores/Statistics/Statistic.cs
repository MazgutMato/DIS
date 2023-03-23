using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.Statistics
{
    public abstract class Statistic
    {
        protected double _sum { get; set; }
        protected double _count { get; set; }
        protected Statistic() { 
            _sum = 0;
            _count = 0;
        }
        public double GetResult()
        {
            return _sum / _count;
        }
    }
}
