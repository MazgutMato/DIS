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

        public Exponential(double lambda) : base()
        {
            _lambda = lambda;
        }

        public override double Next()
        {
            double u = _random.NextDouble();
            return -Math.Log(1 - u) / _lambda;
        }
    }
}
