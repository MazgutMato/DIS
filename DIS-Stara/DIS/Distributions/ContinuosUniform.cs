using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class ContinuosUniform : Distribution
    {
        public double _min { get; }
        public double _max { get; }
        public ContinuosUniform(double min, double max) : base() { 
            _max = max;
            _min = min;
        }
        public override double Next()
        {
            return _min + (_random.NextDouble() * (_max - _min));
        }
    }
}
