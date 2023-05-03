using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation
{
    public class Vehicle
    {
        public int _id { get; }
        public double _arrivalTime { get; set; }
        public VehicleType _vehicleType { get; set; }
        public Vehicle(int id, VehicleType vehicleType, double arrivalTime) { 
            _id = id;
            _arrivalTime = arrivalTime;
            _vehicleType = vehicleType;
        }
        public Vehicle(int id, double arrivalTime)
        {
            _id = id;
            _arrivalTime = arrivalTime;
            _vehicleType = VehicleType.NONE;
        }
        public override string ToString()
        {
            return "ID: " + _id + " Type: " + _vehicleType;
        }
    }

    public enum VehicleType
    {
        NONE,
        CAR,
        VAN,
        TRUCK,
    }
}
