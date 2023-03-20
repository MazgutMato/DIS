using DIS.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores
{
    public class RouteCoreB : SimulationCore
    {
        ICollection<Distribution>? _path;
        public double _elapsedTime;
        public int _onTime; 
        public RouteCoreB(int repCount) : base(repCount)
        {
            _elapsedTime = 0;
            _onTime = 0;
        }
        protected override void BeforeSimulation()
        {
            base.BeforeSimulation();

            _elapsedTime = 0;
            _onTime = 0;

            _path = new List<Distribution>();

            //D-E
            var d_e = new ContinuosUniform(19, 36);
            _path.Add(d_e);

            //E-C
            var e_cParams = new List<EmpiricalParam>();
            e_cParams.Add(new EmpiricalParam(230, 243, 0.3));
            e_cParams.Add(new EmpiricalParam(244, 280, 0.5));
            e_cParams.Add(new EmpiricalParam(281, 350, 0.2));
            var e_c = new DiscreteEmpirical(e_cParams);
            _path.Add(e_c);

            //C-M
            var c_mParams = new List<EmpiricalParam>();
            c_mParams.Add(new EmpiricalParam(3, 10, 0.2));
            c_mParams.Add(new EmpiricalParam(11, 20, 0.2));
            c_mParams.Add(new EmpiricalParam(21, 34, 0.3));
            c_mParams.Add(new EmpiricalParam(35, 52, 0.1));
            c_mParams.Add(new EmpiricalParam(53, 59, 0.15));
            c_mParams.Add(new EmpiricalParam(60, 95, 0.03));
            c_mParams.Add(new EmpiricalParam(96, 180, 0.02));
            var c_m = new DiscreteEmpirical(c_mParams);
            _path.Add(c_m);
        }
        public override double GetResult()
        {
            return ((double)_onTime) / _actualRepCount;
        }
        protected override void RepBody()
        {
            double actualTime = 0;
            foreach (var item in _path)
            {
                actualTime += item.Next();
            }

            _elapsedTime += actualTime;

            if ((actualTime) <= 320)
            {
                _onTime++;
            }
        }
    }
}
