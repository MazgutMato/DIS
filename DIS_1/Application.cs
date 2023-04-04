using DIS.SimulationCores;
using DIS_1.ChartModels;
using DIS.Models.STKSimulation;
using DIS.SimulationCores.EventSimulation;

namespace DIS_1
{
    public partial class Application : Form
    {
        public SimulationCore? _core { get; set; }
        public ChartModel _chartModel { get; set; }
        private DateTime _startTime = new DateTime(2022, 1, 1, 9, 0, 0);
        public Application()
        {
            InitializeComponent();

            buttonTurbo.Enabled = false;
            buttonNormal.Enabled = false;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
        }
        private async void RunSimulation()
        {
            textBoxActualRep.Text = "0";

            if (_core != null)
            {
                _core._dataUpdate += UpdateData;
            }

            await Task.Run(() =>
            {
                _core?.RunSimulation();
            });

            _core = null;
            buttonRun.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                //Local update
                if (_core is STKCore)
                {
                    var core = (STKCore)_core;
                    if (core._mode == Mode.NORMAL)
                    {
                        var actualTime = _startTime.AddSeconds(core._actualTime);
                        textBoxActualTime.Text = actualTime.ToString("HH:mm:ss");

                        dataGridViewLocal.Rows.Clear();

                        //Vehicle in system
                        var dataGridViewRowVehicle = new DataGridViewRow();
                        dataGridViewRowVehicle.CreateCells(dataGridViewLocal, "Vehicle in system", core._vehicleInSystemLocal.GetResult(), "vehicles");
                        dataGridViewLocal.Rows.Add(dataGridViewRowVehicle);

                        //Time in system
                        var dataGridViewRowSystem = new DataGridViewRow();
                        dataGridViewRowSystem.CreateCells(dataGridViewLocal, "Time in system", core._timeInSystemLocal.GetResult() / 60, "minutes");
                        dataGridViewLocal.Rows.Add(dataGridViewRowSystem);

                        //Waiting time
                        var dataGridViewRowWaiting = new DataGridViewRow();
                        dataGridViewRowWaiting.CreateCells(dataGridViewLocal, "Waiting time", core._waitingTimeLocal.GetResult() / 60, "minutes");
                        dataGridViewLocal.Rows.Add(dataGridViewRowWaiting);

                        //Line length                        
                        var dataGridViewRowLine = new DataGridViewRow();
                        dataGridViewRowLine.CreateCells(dataGridViewLocal, "Line length", core._lineLengthLocal.GetResult(), "vehicles");
                        dataGridViewLocal.Rows.Add(dataGridViewRowLine);

                        //Free technical
                        var dataGridViewRowTechnical = new DataGridViewRow();
                        dataGridViewRowTechnical.CreateCells(dataGridViewLocal, "Free technical", core._freeTechnicalLocal.GetResult(), "workers");
                        dataGridViewLocal.Rows.Add(dataGridViewRowTechnical);

                        //Free inspection
                        var dataGridViewRowInspection = new DataGridViewRow();
                        dataGridViewRowInspection.CreateCells(dataGridViewLocal, "Free inspection", core._freeInspectionLocal.GetResult(), "workers");
                        dataGridViewLocal.Rows.Add(dataGridViewRowInspection);

                        //Arrival line
                        textBoxArrival.Text = core._vehicleLine.Count.ToString();
                        dataGridViewArrivalQueue.Rows.Clear();

                        foreach (var vehicle in core._vehicleLine)
                        {
                            var arrivalTime = _startTime.AddSeconds(vehicle._arrivalTime);
                            var outTime = arrivalTime.ToString("HH:mm:ss");
                            // Create a new row and add it to the control
                            var dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(dataGridViewArrivalQueue, vehicle._id, vehicle._vehicleType,
                                outTime);
                            dataGridViewArrivalQueue.Rows.Add(dataGridViewRow);
                        }

                        //Workers INS
                        textBoxIns.Text = (core._inspectionWorkersCount - core._inspectionWorkers.Count).ToString() + "/" +
                            core._inspectionWorkersCount;
                        dataGridViewWorkersIns.Rows.Clear();

                        foreach (var worker in core._workers)
                        {
                            if (worker._type == WorkerType.INSPECTION)
                            {
                                var dataGridViewRow = new DataGridViewRow();
                                dataGridViewRow.CreateCells(dataGridViewWorkersIns, worker._id, worker._type, worker._working, worker._vehicle);
                                dataGridViewWorkersIns.Rows.Add(dataGridViewRow);
                            }
                        }

                        //Workers TECH
                        textBoxTechnical.Text = (core._technicWorkersCount - core._technicWorkers.Count).ToString() + "/" +
                            core._technicWorkersCount;
                        dataGridViewWorkersTech.Rows.Clear();

                        foreach (var worker in core._workers)
                        {
                            if (worker._type == WorkerType.TECHNICAL)
                            {
                                var dataGridViewRow = new DataGridViewRow();
                                dataGridViewRow.CreateCells(dataGridViewWorkersTech, worker._id, worker._type, worker._working, worker._vehicle);
                                dataGridViewWorkersTech.Rows.Add(dataGridViewRow);
                            }
                        }


                        //Inpsection parking
                        textBoxInsP.Text = core._inspectionParking.Count.ToString() + "/" +
                            core._inspectionParkingCapacity;
                        dataGridViewInspectionParking.Rows.Clear();

                        foreach (var vehicle in core._inspectionParking)
                        {
                            // Create a new row and add it to the control
                            var dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(dataGridViewInspectionParking, vehicle._id, vehicle._vehicleType);
                            dataGridViewInspectionParking.Rows.Add(dataGridViewRow);
                        }

                        //Payment parking
                        textBoxPayment.Text = core._paymentParking.Count.ToString();
                        dataGridViewPaymentParking.Rows.Clear();

                        foreach (var vehicle in core._paymentParking)
                        {
                            // Create a new row and add it to the control
                            var dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(dataGridViewPaymentParking, vehicle._id, vehicle._vehicleType);
                            dataGridViewPaymentParking.Rows.Add(dataGridViewRow);
                        }
                    }
                }

                if (_core is STKCore)
                {
                    var core = (STKCore)_core;

                    //GlobalUpdate
                    textBoxActualRep.Text = _core._actualRepCount.ToString();

                    dataGridViewGlobal.Rows.Clear();

                    //Vehicle in system
                    var dataGridViewRowVehicle = new DataGridViewRow();
                    dataGridViewRowVehicle.CreateCells(dataGridViewGlobal, "Vehicle in system", core._vehicleInSystemGlobal.GetResult(), "vehicles");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicle);

                    //Vehicle in system IS
                    var vehicleInIs = core._vehicleInSystemGlobal.ConfidenceInterval(95);
                    var dataGridViewRowVehicleIS = new DataGridViewRow();
                    dataGridViewRowVehicleIS.CreateCells(dataGridViewGlobal, "Vehicle in system IS", "(" + Math.Round(vehicleInIs.Item1, 5) +
                        " ; " + Math.Round(vehicleInIs.Item2, 5) + ")", "vehicles");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicleIS);

                    //Vehicle in system at the End
                    var dataGridViewRowEnd = new DataGridViewRow();
                    dataGridViewRowEnd.CreateCells(dataGridViewGlobal, "Vehicles at the End", core._vehiclesAtTheEnd.GetResult(), "vehicles");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowEnd);

                    //Time in system
                    var dataGridViewRowSystem = new DataGridViewRow();
                    dataGridViewRowSystem.CreateCells(dataGridViewGlobal, "Time in system", core._timeInSystemGlobal.GetResult() / 60, "minutes");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowSystem);

                    //Time in system
                    var timeInIS = core._timeInSystemGlobal.ConfidenceInterval(90);
                    var dataGridViewRowSystemIS = new DataGridViewRow();
                    dataGridViewRowSystemIS.CreateCells(dataGridViewGlobal, "Time in system IS", "(" + Math.Round(timeInIS.Item1 / 60, 5) +
                        " ; " + Math.Round(timeInIS.Item2 / 60, 5) + ")", "minutes");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowSystemIS);

                    //Waiting time
                    var dataGridViewRowWaiting = new DataGridViewRow();
                    dataGridViewRowWaiting.CreateCells(dataGridViewGlobal, "Waiting time", core._waitingTimeGlobal.GetResult() / 60, "minutes");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowWaiting);

                    //Vehicle line
                    var dataGridViewRowLine = new DataGridViewRow();
                    dataGridViewRowLine.CreateCells(dataGridViewGlobal, "Line length", core._lineLengthGlobal.GetResult(), "vehicles");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowLine);

                    //Free technical
                    var dataGridViewRowTechnical = new DataGridViewRow();
                    dataGridViewRowTechnical.CreateCells(dataGridViewGlobal, "Free technical", core._freeTechnicalGlobal.GetResult(), "workers");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowTechnical);

                    //Free inspection
                    var dataGridViewRowInspection = new DataGridViewRow();
                    dataGridViewRowInspection.CreateCells(dataGridViewGlobal, "Free inspection", core._freeInspectionGlobal.GetResult(), "workers");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowInspection);

                }
            }));
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //Simulation is paused
            if (_core != null && _core._pause == true)
            {
                _core._pause = false;
                buttonRun.Enabled = false;
                buttonPause.Enabled = true;

                var paused_core = (STKCore)_core;
                if (paused_core._mode == Mode.NORMAL)
                {
                    buttonNormal.Enabled = false;
                    buttonTurbo.Enabled = true;
                }
                else
                {
                    buttonNormal.Enabled = true;
                    buttonTurbo.Enabled = false;
                }

                return;
            }

            //New simulation
            var repCount = Convert.ToInt32(UpDownRepCount.Value);

            _core = new STKCore(repCount, 8 * 60 * 60);
            var core = (STKCore)_core;
            core._technicWorkersCount = Convert.ToInt32(technicalWorkers.Value);
            core._inspectionWorkersCount = Convert.ToInt32(inspectionWorkers.Value);
            core._dataGenerate = Convert.ToInt32(UpDownRepRefresh.Value); ;

            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;
            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
            UpDownSpeed.Value = 1;
            UpDownRefresh.Value = 1;
            technicalWorkers.Enabled = false;
            inspectionWorkers.Enabled = false;
            UpDownRepRefresh.Enabled = false;
            UpDownRepCount.Enabled = false;

            RunSimulation();
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            if (_core == null || _core is not EventCore)
            {
                return;
            }

            var core = (EventCore)_core;

            if (core._mode == Mode.TURBO)
            {
                core._pause = true;
                core.AddEvent(new SystemEvent(core._actualTime, core));
                core._pause = false;
            }
            core._mode = Mode.NORMAL;

            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
            UpDownSpeed.Enabled = true;
            UpDownRefresh.Enabled = true;
        }

        private void buttonTurbo_Click(object sender, EventArgs e)
        {
            if (_core == null || _core is not EventCore)
            {
                return;
            }

            var core = (EventCore)_core;
            core._mode = Mode.TURBO;

            dataGridViewArrivalQueue.Rows.Clear();
            dataGridViewLocal.Rows.Clear();
            dataGridViewPaymentParking.Rows.Clear();
            dataGridViewInspectionParking.Rows.Clear();
            dataGridViewWorkersIns.Rows.Clear();
            dataGridViewWorkersTech.Rows.Clear();
            textBoxActualTime.Text = string.Empty;
            textBoxIns.Text = string.Empty;
            textBoxTechnical.Text = string.Empty;
            textBoxInsP.Text = string.Empty;
            textBoxPayment.Text = string.Empty;
            textBoxArrival.Text = string.Empty;

            buttonNormal.Enabled = true;
            buttonTurbo.Enabled = false;
            UpDownSpeed.Enabled = false;
            UpDownRefresh.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_core != null)
            {
                _core._stopSimulation = true;
            }

            buttonRun.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
            technicalWorkers.Enabled = true;
            inspectionWorkers.Enabled = true;
            UpDownRepRefresh.Enabled = true;
            UpDownRepCount.Enabled = true;
            buttonTurbo.Enabled = false;
            buttonNormal.Enabled = false;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _core._pause = true;
            buttonRun.Enabled = true;
            buttonPause.Enabled = false;
            buttonTurbo.Enabled = false;
            buttonNormal.Enabled = false;
        }

        private void UpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (_core != null && _core is EventCore)
            {
                var core = (EventCore)_core;

                core._speed = Convert.ToDouble(UpDownSpeed.Value);
            }
        }

        private void UpDownRefresh_ValueChanged(object sender, EventArgs e)
        {
            if (_core != null && _core is EventCore)
            {
                var core = (EventCore)_core;

                core._refreshTime = Convert.ToDouble(UpDownRefresh.Value);
            }
        }
    }
}