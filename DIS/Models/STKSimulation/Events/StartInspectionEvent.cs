using DIS.SimulationCores.EventSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS.Models.STKSimulation.Events
{
    public class StartInspectionEvent : STKEvent
    {
        public StartInspectionEvent(double eventTime, EventCore core, Worker worker) : base(eventTime, core, worker)
        {
        }
        public override void Execute()
        {
            base.Execute();

            var core = (STKCore)_myCore;

            //End of inspection
            var vehicle = _worker._vehicle;
            double inspectionTime;
            switch (vehicle._vehicleType)
            {
                case VehicleType.NONE:
                    throw new Exception("Vehicle type is not set!");
                    break;
                case VehicleType.CAR:
                    inspectionTime = core._generators[4].Next();
                    break;
                case VehicleType.VAN:
                    inspectionTime = core._generators[5].Next();
                    break;
                case VehicleType.TRUCK:
                    break;
                default:                    
                    break;
            }


            //Start taking
            if(core._technicWorkers.Count != 0)
            {

            }
        }
    }
}
