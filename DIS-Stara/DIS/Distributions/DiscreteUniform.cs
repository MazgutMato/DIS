using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class DiscreteUniform : Distribution
    {
        public int _min {  get; }
        public int _max { get; }
        public DiscreteUniform(int min, int max) : base()
        {
            _max = max;
            _min = min;
        }
        public override double Next()
        {
            return _random.Next(_min, _max + 1);
        }
    }
}
