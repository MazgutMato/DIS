using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.Statistics
{
    public class NormalStatistic : Statistic
    {
        public NormalStatistic() : base()
        {
        }

        public override void AddValue(double value)
        {
            _sum += value;
            _sum2 += Math.Pow(value,2);
            _count += 1;
        }
    }
}
