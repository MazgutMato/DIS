using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public static class SeedGenerator
    {
        private static Random _random = new Random();
        public static int GetSeed()
        {
            return _random.Next();
        }
    }
}
