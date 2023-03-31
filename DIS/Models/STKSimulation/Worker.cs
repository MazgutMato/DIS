using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation
{
    public class Worker
    {
        public int _id { get; }
        public Vehicle? _vehicle { get; set; }
        public Worker(int id)
        {
            _vehicle = null;
            _id = id;
        }
        public Worker(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
    }
}
