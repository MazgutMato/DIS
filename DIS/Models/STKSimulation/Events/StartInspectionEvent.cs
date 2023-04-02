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

            //Set working type
            _worker._working = Working.INSPECT;

            //End of inspection
            var vehicle = _worker._vehicle;
            double inspectionTime = 0;
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
                    inspectionTime = core._generators[6].Next();
                    break;
                default:                    
                    break;
            }

            if(inspectionTime != 0)
            {
                core.AddEvent(new EndInspectionEvent(core._actualTime + inspectionTime * 60,
                    core, _worker));
            }
            else
            {
                throw new Exception("Invalid inspection time!");
            }

            //Start taking
            if (core._technicWorkers.Count > 0 && core._takeCarsCount + core._inspectionParking.Count
                < core._inspectionParkingCapacity && core._vehicleLine.Count > 0)
            {
                core._takeCarsCount++;
                var takingWorker = core._technicWorkers.Dequeue();
                takingWorker._vehicle = core._vehicleLine.Dequeue();
                core.AddEvent(new StartTakingEvent(core._actualTime, core, takingWorker));
            }
        }
    }
}
