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

            textBoxRepCount.Text = "1000000";
            textBoxRepRefresh.Text = "1000";
            trackBarSpeed.Value = 1;
            textBoxSpeed.Text = "1";
            trackBarRefresh.Value = 1;
            textBoxRefresh.Text = "1";

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
            Invoke((Action)(()=>
            {
            //Local update
            if (_core is STKCore)
            {
                var core = (STKCore)_core;
                if (core._mode == Mode.NORMAL)
                {
                    var actualTime = _startTime.AddSeconds(core._actualTime);
                    textBoxActualTime.Text = "" + actualTime.Hour + ":" + actualTime.Minute
                        + ":" + actualTime.Second;

                    dataGridViewLocal.Rows.Clear();

                    //Time in system
                    var dataGridViewRowSystem = new DataGridViewRow();
                    dataGridViewRowSystem.CreateCells(dataGridViewLocal, "Time in system", core._timeInSystemLocal.GetResult() / 60, "minutes");
                    dataGridViewLocal.Rows.Add(dataGridViewRowSystem);

                    //Waiting time
                    var dataGridViewRowWaiting = new DataGridViewRow();
                    dataGridViewRowWaiting.CreateCells(dataGridViewLocal, "Waiting time", core._waitingTimeLocal.GetResult() / 60, "minutes");
                    dataGridViewLocal.Rows.Add(dataGridViewRowWaiting);

                    //Arrival line
                    dataGridViewArrivalQueue.Rows.Clear();

                    foreach (var vehicle in core._vehicleLine)
                    {
                        var arrivalTime = _startTime.AddSeconds(vehicle._arrivalTime);
                        var outTime = "" + arrivalTime.Hour + ":" + arrivalTime.Minute
                        + ":" + arrivalTime.Second;
                        // Create a new row and add it to the control
                        var dataGridViewRow = new DataGridViewRow();
                        dataGridViewRow.CreateCells(dataGridViewArrivalQueue, vehicle._id, vehicle._vehicleType,
                            outTime);
                        dataGridViewArrivalQueue.Rows.Add(dataGridViewRow);
                    }

                    //Workers
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

                    //Workers
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
                    dataGridViewInspectionParking.Rows.Clear();

                    foreach (var vehicle in core._inspectionParking)
                    {
                        // Create a new row and add it to the control
                        var dataGridViewRow = new DataGridViewRow();
                        dataGridViewRow.CreateCells(dataGridViewInspectionParking, vehicle._id, vehicle._vehicleType);
                        dataGridViewInspectionParking.Rows.Add(dataGridViewRow);
                    }

                    //Payment parking
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

                //Time in system
                var dataGridViewRowSystem = new DataGridViewRow();
                dataGridViewRowSystem.CreateCells(dataGridViewGlobal, "Time in system", core._timeInSystemGlobal.GetResult() / 60, "minutes");
                dataGridViewGlobal.Rows.Add(dataGridViewRowSystem);

                //Waiting time
                var dataGridViewRowWaiting = new DataGridViewRow();
                dataGridViewRowWaiting.CreateCells(dataGridViewGlobal, "Waiting time", core._waitingTimeGlobal.GetResult() / 60, "minutes");
                dataGridViewGlobal.Rows.Add(dataGridViewRowWaiting);

                //Vehicle in system
                var dataGridViewRowVehicle = new DataGridViewRow();
                dataGridViewRowVehicle.CreateCells(dataGridViewGlobal, "Vehicles in system", core._vehicleInSystemGlobal.GetResult(), "vehicles");
                dataGridViewGlobal.Rows.Add(dataGridViewRowVehicle);

                //Vehicle inspected
                var dataGridViewRowInspected = new DataGridViewRow();
                dataGridViewRowInspected.CreateCells(dataGridViewGlobal, "Count of vehicles", core._totalVehicleGlobal.GetResult(), "vehicles");
                dataGridViewGlobal.Rows.Add(dataGridViewRowInspected);
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

                return;
            }

            //New simulation
            var repCount = Convert.ToInt32(textBoxRepCount.Text);

            _core = new STKCore(repCount, 8 * 60 * 60);
            var core = (STKCore)_core;
            core._technicWorkersCount = Convert.ToInt32(technicalWorkers.Value);
            core._inspectionWorkersCount = Convert.ToInt32(inspectionWorkers.Value);
            core._dataGenerate = Convert.ToInt32(textBoxRepRefresh.Text);

            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;
            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
            textBoxSpeed.Text = "1";
            trackBarSpeed.Value = 1;
            textBoxRefresh.Text = "1";
            trackBarRefresh.Value = 1;
            technicalWorkers.Enabled = false;
            inspectionWorkers.Enabled = false;


            RunSimulation();
        }

        private void trackBarRefresh_Scroll(object sender, EventArgs e)
        {
            if (_core != null && _core is EventCore)
            {
                var core = (EventCore)_core;

                core._refreshTime = trackBarRefresh.Value;
                textBoxRefresh.Text = trackBarRefresh.Value.ToString();
            }
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            if (_core == null || _core is not EventCore)
            {
                return;
            }
            
            var core = (EventCore)_core;

            if(core._mode == Mode.TURBO)
            {
                core._pause = true;
                core.AddEvent(new SystemEvent(core._actualTime, core));
                core._pause = false;
            }
            core._mode = Mode.NORMAL;

            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
        }

        private void buttonTurbo_Click(object sender, EventArgs e)
        {
            if (_core == null || _core is not EventCore)
            {
                return;
            }

            var core = (EventCore)_core;
            core._mode = Mode.TURBO;

            buttonNormal.Enabled = true;
            buttonTurbo.Enabled = false;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            if (_core != null && _core is EventCore)
            {
                var core = (EventCore)_core;

                core._speed = trackBarSpeed.Value;
                textBoxSpeed.Text = trackBarSpeed.Value.ToString();
            }
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
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _core._pause = true;
            buttonRun.Enabled = true;
            buttonPause.Enabled = false;
        }
    }
}