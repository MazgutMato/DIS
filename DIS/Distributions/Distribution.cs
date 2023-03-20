using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public abstract class Distribution
    {
        protected Random _random;
        protected Distribution()
        {
            _random = new Random(SeedGenerator.GetSeed());
        }
        public abstract double Next();
    }
}
