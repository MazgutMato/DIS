using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Distributions
{
    public class EmpiricalParam
    {
        public double _probability { get; }
        public DiscreteUniform _distribution { get; }
        public EmpiricalParam(int min, int max, double probability)
        {
            _probability = probability;
            _distribution = new DiscreteUniform(min, max);
        }
    }
    public class DiscreteEmpirical : Distribution
    {
        public ICollection<EmpiricalParam> _empiricalParams { get; }
        public DiscreteEmpirical(ICollection<EmpiricalParam> empiciralParams) : base()
        {
            _empiricalParams = empiciralParams;

            double sumOfProbability = 0;
            foreach (var param in _empiricalParams)
            {
                sumOfProbability += param._probability;
            }

            if (sumOfProbability <= 0.98 || sumOfProbability > 1) {
                throw new ArgumentException("Probability is not equal 1!");
            }
        }
        public override double Next()
        {
            var generateProbability = _random.NextDouble();

            double actualProbability = 0;
            foreach(var distribution in _empiricalParams)
            {
                actualProbability += distribution._probability;
                if(generateProbability < actualProbability)
                {
                    return distribution._distribution.Next();
                }
            }

            return -1;
        }
    }
}
