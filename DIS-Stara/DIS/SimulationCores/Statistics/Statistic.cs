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
        private const double _ta_95 = 1.96;
        private const double _ta_90 = 1.64;
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
            return Math.Sqrt( (_sum2 - (Math.Pow(_sum,2)/_count)) / _count - 1 );
        }
        public Tuple<double, double> ConfidenceInterval(int percentage)
        {
            if(_count < 30)
            {
                return new Tuple<double, double>(0, 0);
            }

            double _ta;

            switch (percentage)
            {
                case 90:
                    _ta = _ta_90;
                    break;
                case 95:
                    _ta = _ta_95;
                    break;
                default:
                    throw new Exception("Unknow percentage!");
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
            if(_count > 0)
            {
                return _sum / _count;
            }
            else
            {
                return 0;
            }
        }
    }
}
