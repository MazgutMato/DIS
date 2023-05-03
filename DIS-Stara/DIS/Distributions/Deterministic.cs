using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class Deterministic : Distribution
    {
        public int _value { get; }
        public Deterministic(int value) : base() { 
            _value = value;
        }
        public override double Next()
        {
            return _value;
        }
    }
}
