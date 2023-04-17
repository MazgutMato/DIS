using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.EventSimulation.STKSimulation
{
    public enum WorkerType
    {
        TECHNICAL,
        INSPECTION,
    }
    public enum Working
    {
        NONE,
        TAKING,
        INSPECT,
        PAYMENT,
    }
    public class Worker
    {
        public int _id { get; }
        public Vehicle? _vehicle { get; set; }
        public WorkerType _type { get; set; }
        public Working _working { get; set; }
        public Worker(int id, WorkerType type)
        {
            _vehicle = null;
            _id = id;
            _type = type;
            _working = Working.NONE;
        }
        public Worker(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
    }
}
