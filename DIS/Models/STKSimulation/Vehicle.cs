using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation
{
    public class Vehicle
    {
        public double _arrivalTime { get; set; }
        public VehicleType _vehicleType { get; set; }
        public Vehicle(VehicleType vehicleType, double arrivalTime) { 
            _arrivalTime = arrivalTime;
            _vehicleType = vehicleType;
        }
        public Vehicle(double arrivalTime)
        {
            _arrivalTime = arrivalTime;
            _vehicleType = VehicleType.NONE;
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
