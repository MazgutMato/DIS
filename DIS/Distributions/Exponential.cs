using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class Exponential : Distribution
    {
        private double _lambda;

        public Exponential(double mean) : base()
        {
            _lambda = 1/mean;
        }

        public override double Next()
        {
            double u = _random.NextDouble();
            return -Math.Log(1 - u) / _lambda;
        }
    }
}
