using DIS.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.RouteSimulation
{
    public class RouteCoreA : SimulationCore
    {
        ICollection<Distribution>? _path;
        public double _elapsedTime { get; set; }
        public double _waitingTime { get; set; }
        public RouteCoreA(int repCount) : base(repCount)
        {
            _waitingTime = 0;
            _elapsedTime = 0;
        }
        protected override void BeforeSimulation()
        {
            base.BeforeSimulation();

            _waitingTime = 0;
            _elapsedTime = 0;
            _path = new List<Distribution>();

            //A-B
            var a_b = new DiscreteUniform(39, 64);
            _path.Add(a_b);

            //B-C
            var b_c = new Deterministic(57);
            _path.Add(b_c);

            //C-M
            var eParams = new List<EmpiricalParam>();
            eParams.Add(new EmpiricalParam(3, 10, 0.2));
            eParams.Add(new EmpiricalParam(11, 20, 0.2));
            eParams.Add(new EmpiricalParam(21, 34, 0.3));
            eParams.Add(new EmpiricalParam(35, 52, 0.1));
            eParams.Add(new EmpiricalParam(53, 59, 0.15));
            eParams.Add(new EmpiricalParam(60, 95, 0.03));
            eParams.Add(new EmpiricalParam(96, 180, 0.02));
            var c_m = new DiscreteEmpirical(eParams);
            _path.Add(c_m);
        }
        protected override void RepBody()
        {
            double actualTime = 0;
            foreach (var item in _path)
            {
                actualTime += item.Next();
            }

            _elapsedTime += actualTime;

            if (actualTime - 125 > 0)
            {
                _waitingTime += actualTime - 125;
            }


        }
        public override double GetResult()
        {
            return _waitingTime / _actualRepCount;
        }
    }
}
