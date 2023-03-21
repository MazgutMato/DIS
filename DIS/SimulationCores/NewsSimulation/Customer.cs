using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.SimulationCores.NewsSimulation
{
    public class Customer
    {
        public double _arrivalTime { get; set; }
        public Customer(double arrivalTime) { 
            _arrivalTime = arrivalTime;
        }
    }
}
