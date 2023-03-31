using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation
{
    public class Worker
    {
        public Vehicle? _vehicle { get; set; }
        public Worker()
        {            
            _vehicle = null;
        }
        public Worker(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
    }
}
