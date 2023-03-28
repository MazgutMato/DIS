using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.Statistics
{
    public abstract class Statistic
    {
        private const double _ta = 1.96;
        protected double _sum { get; set; }
        protected double _sum2{ get; set; }
        protected double _count { get; set; }
        protected Statistic() { 
            _sum = 0;
            _count = 0;
            _sum2 = 0;
        }
        public abstract void AddValue(double value);
        public double StandardDeviation()
        {
            var _const = 1 / (_count - 1);
            return Math.Sqrt( (_const*_sum2) - Math.Pow((_const * _sum),2) );
        }
        public Tuple<double, double> ConfidenceInterval()
        {
            if(_count < 30)
            {
                throw new Exception("Count is less then 30!");
            }

            var s = this.StandardDeviation();
            var sqrtN = Math.Sqrt(_count);
            var rightSide = (s * _ta / sqrtN);
            var average = this.GetResult();

            var result = new Tuple<double, double>(average - rightSide, average + rightSide);
            return result;
        }
        public double GetResult()
        {
            return _sum / _count;
        }
    }
}
