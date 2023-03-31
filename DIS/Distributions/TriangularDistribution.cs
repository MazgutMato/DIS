using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class TriangularDistribution : Distribution
    {
        private double _min;
        private double _max;
        private double _mode;

        public TriangularDistribution(double min, double max, double mode)
        {
            _min = min;
            _max = max;
            _mode = mode;
        }

        public override double Next()
        {
            double u = _random.NextDouble();
            double c = (_mode - _min) / (_max - _min);
            if (u <= c)
            {
                return _min + Math.Sqrt(u * (_max - _min) * (_mode - _min));
            }
            else
            {
                return _max - Math.Sqrt((1 - u) * (_max - _min) * (_max - _mode));
            }
        }
    }
}
