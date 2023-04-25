using DIS.SimulationCores;
using DIS_1.ChartModels;
using DIS.SimulationCores.EventSimulation;
using DIS.Models.EventSimulation.STKSimulation;
using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;

namespace DIS_1
{
    public partial class Application : Form
    {
        public MySimulation _core { get; set; }
        public MySimulation _coreChart1 { get; set; }
        public MySimulation _coreChart2 { get; set; }
        public ChartModel _chartModel1 { get; set; }
        public ChartModel _chartModel2 { get; set; }
        private DateTime _startTime = new DateTime(2022, 1, 1, 9, 0, 0);
        public bool _isRunning { get; set; } = false;
        public bool _isPaused { get; set; } = false;
        public bool _isRunningChart1 { get; set; } = false;
        public bool _isRunningChart2 { get; set; } = false;
        public Application()
        {
            InitializeComponent();
            InitializeCharts();
            InitializeGui();
            InitializeSim();
        }
        private void InitializeSim()
        {
            _core = new MySimulation();
            _core.SetSimSpeed(1, 1);            

            _core.OnRefreshUI(RefreshUI);
            _core.OnSimulationWillStart(OnSimulationWillStart);
            _core.OnReplicationWillStart(OnReplicationWillStart);
            _core.OnReplicationDidFinish(OnReplicationDidFinish);
            _core.OnSimulationDidFinish(OnSimulationDidFinish);
        }
        private void InitializeGui()
        {
            textBoxActualRep.Text = "0";            
        }
        private void InitializeCharts()
        {
            _coreChart1 = new MySimulation();
            buttonStopChart1.Enabled = false;
            _chartModel1 = new ChartModel();
            cartesianChart1.Series = _chartModel1._series;
            cartesianChart1.XAxes = _chartModel1._xAxes;
            cartesianChart1.YAxes = _chartModel1._yAxes;
            _chartModel1.RenameX("Count of technical workers");
            _chartModel1.RenameY("Average of waiting vehicles");

            _coreChart2 = new MySimulation();
            buttonStopChart2.Enabled = false;
            _chartModel2 = new ChartModel();
            cartesianChart2.Series = _chartModel2._series;
            cartesianChart2.XAxes = _chartModel2._xAxes;
            cartesianChart2.YAxes = _chartModel2._yAxes;
            _chartModel2.RenameX("Count of inspection workers");
            _chartModel2.RenameY("Average time in system / min");
        }
        private void OnSimulationWillStart(Simulation obj)
        {
            _isRunning = true;
            _isPaused = false;
        }
        private void OnSimulationDidFinish(Simulation obj)
        {
            _isRunning = false;
            _isPaused = false;
        }
        private void RefreshUI(Simulation simulation)
        {
            Invoke((System.Action)(() =>
            {                
                var actualTime = _startTime.AddSeconds(simulation.CurrentTime);
                textBoxActualTime.Text = actualTime.ToString("HH:mm:ss");
                textBoxActualRep.Text = simulation.CurrentReplication.ToString();

                //dataGridViewLocal.Rows.Clear();

                ////Vehicle in system
                //var dataGridViewRowVehicle = new DataGridViewRow();
                //dataGridViewRowVehicle.CreateCells(dataGridViewLocal, "Vehicle in system", core._vehicleInSystemLocal.GetResult(), "vehicles");
                //dataGridViewLocal.Rows.Add(dataGridViewRowVehicle);

                ////Time in system
                //var dataGridViewRowSystem = new DataGridViewRow();
                //dataGridViewRowSystem.CreateCells(dataGridViewLocal, "Time in system", core._timeInSystemLocal.GetResult() / 60, "minutes");
                //dataGridViewLocal.Rows.Add(dataGridViewRowSystem);

                ////Waiting time
                //var dataGridViewRowWaiting = new DataGridViewRow();
                //dataGridViewRowWaiting.CreateCells(dataGridViewLocal, "Waiting time", core._waitingTimeLocal.GetResult() / 60, "minutes");
                //dataGridViewLocal.Rows.Add(dataGridViewRowWaiting);

                ////Line length                        
                //var dataGridViewRowLine = new DataGridViewRow();
                //dataGridViewRowLine.CreateCells(dataGridViewLocal, "Line length", core._lineLengthLocal.GetResult(), "vehicles");
                //dataGridViewLocal.Rows.Add(dataGridViewRowLine);

                ////Free technical
                //var dataGridViewRowTechnical = new DataGridViewRow();
                //dataGridViewRowTechnical.CreateCells(dataGridViewLocal, "Free technical", core._freeTechnicalLocal.GetResult(), "workers");
                //dataGridViewLocal.Rows.Add(dataGridViewRowTechnical);

                ////Free inspection
                //var dataGridViewRowInspection = new DataGridViewRow();
                //dataGridViewRowInspection.CreateCells(dataGridViewLocal, "Free inspection", core._freeInspectionLocal.GetResult(), "workers");
                //dataGridViewLocal.Rows.Add(dataGridViewRowInspection);

                ////Arrival line
                //textBoxArrival.Text = core._vehicleLine.Count.ToString();
                //dataGridViewArrivalQueue.Rows.Clear();

                //foreach (var vehicle in core._vehicleLine)
                //{
                //    var arrivalTime = _startTime.AddSeconds(vehicle._arrivalTime);
                //    var outTime = arrivalTime.ToString("HH:mm:ss");
                //    // Create a new row and add it to the control
                //    var dataGridViewRow = new DataGridViewRow();
                //    dataGridViewRow.CreateCells(dataGridViewArrivalQueue, vehicle._id, vehicle._vehicleType,
                //        outTime);
                //    dataGridViewArrivalQueue.Rows.Add(dataGridViewRow);
                //}

                ////Workers INS
                //textBoxIns.Text = (core._inspectionWorkersCount - core._inspectionWorkers.Count).ToString() + "/" +
                //    core._inspectionWorkersCount;
                //dataGridViewWorkersIns.Rows.Clear();

                //foreach (var worker in core._workers)
                //{
                //    if (worker._type == WorkerType.INSPECTION)
                //    {
                //        var dataGridViewRow = new DataGridViewRow();
                //        dataGridViewRow.CreateCells(dataGridViewWorkersIns, worker._id, worker._type, worker._working, worker._vehicle);
                //        dataGridViewWorkersIns.Rows.Add(dataGridViewRow);
                //    }
                //}

                ////Workers TECH
                //textBoxTechnical.Text = (core._technicWorkersCount - core._technicWorkers.Count).ToString() + "/" +
                //    core._technicWorkersCount;
                //dataGridViewWorkersTech.Rows.Clear();

                //foreach (var worker in core._workers)
                //{
                //    if (worker._type == WorkerType.TECHNICAL)
                //    {
                //        var dataGridViewRow = new DataGridViewRow();
                //        dataGridViewRow.CreateCells(dataGridViewWorkersTech, worker._id, worker._type, worker._working, worker._vehicle);
                //        dataGridViewWorkersTech.Rows.Add(dataGridViewRow);
                //    }
                //}


                ////Inpsection parking
                //textBoxInsP.Text = core._inspectionParking.Count.ToString() + "/" +
                //    core._inspectionParkingCapacity;
                //dataGridViewInspectionParking.Rows.Clear();

                //foreach (var vehicle in core._inspectionParking)
                //{
                //    // Create a new row and add it to the control
                //    var dataGridViewRow = new DataGridViewRow();
                //    dataGridViewRow.CreateCells(dataGridViewInspectionParking, vehicle._id, vehicle._vehicleType);
                //    dataGridViewInspectionParking.Rows.Add(dataGridViewRow);
                //}

                ////Payment parking
                //textBoxPayment.Text = core._paymentParking.Count.ToString();
                //dataGridViewPaymentParking.Rows.Clear();

                //foreach (var vehicle in core._paymentParking)
                //{
                //    // Create a new row and add it to the control
                //    var dataGridViewRow = new DataGridViewRow();
                //    dataGridViewRow.CreateCells(dataGridViewPaymentParking, vehicle._id, vehicle._vehicleType);
                //    dataGridViewPaymentParking.Rows.Add(dataGridViewRow);
                //}                
            }));
        }
        private void OnReplicationDidFinish(Simulation obj)
        {
            if ((_core.CurrentReplication % UpDownRepRefresh.Value) == 0)
            {
                Invoke((System.Action)(() =>
                {
                //GlobalUpdate
                textBoxActualRep.Text = _core.CurrentReplication.ToString();

                //    dataGridViewGlobal.Rows.Clear();

                //    //Vehicle in system
                //    var dataGridViewRowVehicle = new DataGridViewRow();
                //    dataGridViewRowVehicle.CreateCells(dataGridViewGlobal, "Vehicle in system", core._vehicleInSystemGlobal.GetResult(), "vehicles");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicle);

                //    //Vehicle in system IS
                //    var vehicleInIs = core._vehicleInSystemGlobal.ConfidenceInterval(95);
                //    var dataGridViewRowVehicleIS = new DataGridViewRow();
                //    dataGridViewRowVehicleIS.CreateCells(dataGridViewGlobal, "Vehicle in system IS", "(" + Math.Round(vehicleInIs.Item1, 5) +
                //        " ; " + Math.Round(vehicleInIs.Item2, 5) + ")", "vehicles");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicleIS);

                //    //Vehicle in system at the End
                //    var dataGridViewRowEnd = new DataGridViewRow();
                //    dataGridViewRowEnd.CreateCells(dataGridViewGlobal, "Vehicles at the End", core._vehiclesAtTheEnd.GetResult(), "vehicles");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowEnd);

                //    //Time in system
                //    var dataGridViewRowSystem = new DataGridViewRow();
                //    dataGridViewRowSystem.CreateCells(dataGridViewGlobal, "Time in system", core._timeInSystemGlobal.GetResult() / 60, "minutes");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowSystem);

                //    //Time in system
                //    var timeInIS = core._timeInSystemGlobal.ConfidenceInterval(90);
                //    var dataGridViewRowSystemIS = new DataGridViewRow();
                //    dataGridViewRowSystemIS.CreateCells(dataGridViewGlobal, "Time in system IS", "(" + Math.Round(timeInIS.Item1 / 60, 5) +
                //        " ; " + Math.Round(timeInIS.Item2 / 60, 5) + ")", "minutes");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowSystemIS);

                //    //Waiting time
                //    var dataGridViewRowWaiting = new DataGridViewRow();
                //    dataGridViewRowWaiting.CreateCells(dataGridViewGlobal, "Waiting time", core._waitingTimeGlobal.GetResult() / 60, "minutes");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowWaiting);

                //    //Vehicle line
                //    var dataGridViewRowLine = new DataGridViewRow();
                //    dataGridViewRowLine.CreateCells(dataGridViewGlobal, "Line length", core._lineLengthGlobal.GetResult(), "vehicles");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowLine);

                //    //Free technical
                //    var dataGridViewRowTechnical = new DataGridViewRow();
                //    dataGridViewRowTechnical.CreateCells(dataGridViewGlobal, "Free technical", core._freeTechnicalGlobal.GetResult(), "workers");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowTechnical);

                //    //Free inspection
                //    var dataGridViewRowInspection = new DataGridViewRow();
                //    dataGridViewRowInspection.CreateCells(dataGridViewGlobal, "Free inspection", core._freeInspectionGlobal.GetResult(), "workers");
                //    dataGridViewGlobal.Rows.Add(dataGridViewRowInspection);
            }));
            }
        }
        private void OnReplicationWillStart(Simulation obj)
        {
            //
        }
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            SetNormalSpeed();
        }
        private void SetNormalSpeed()
        {
            _core.SetSimSpeed(Convert.ToDouble(UpDownRefresh.Value), Convert.ToDouble(UpDownSpeed.Value));
        }

        private void buttonTurbo_Click(object sender, EventArgs e)
        {
            _core.SetMaxSimSpeed();
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
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            //Simulation is paused
            if (!_isRunning)
            {
                var pocetReplikacii = Convert.ToInt32(UpDownRepCount.Value);

                _isRunning = true;
                //core._technicWorkersCount = Convert.ToInt32(technicalWorkers.Value);
                //core._inspectionWorkersCount = Convert.ToInt32(inspectionWorkers.Value);
                //core._dataGenerate = Convert.ToInt32(UpDownRepRefresh.Value);
                _core.SimulateAsync(pocetReplikacii, 8 * 60 * 60);
                buttonRun.Enabled = false;
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _core.StopSimulation();
                _isRunning = false;
                buttonRun.Enabled = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                if (!_isPaused)
                {
                    _isPaused = true;
                    _core.PauseSimulation();
                    buttonPause.Text = "Continue";
                }
                else // resume
                {
                    _isPaused = false;
                    _core.ResumeSimulation();
                    buttonPause.Text = "Pause";
                }
            }
        }
        private void UpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            SetNormalSpeed();
        }
        private void UpDownRefresh_ValueChanged(object sender, EventArgs e)
        {
            SetNormalSpeed();
        }
        private void buttonRunChart1_Click(object sender, EventArgs e)
        {
            if (!_isRunningChart1)
            {
                for (int i = 1; i < 16; i++)
                {
                    var repCount = Convert.ToInt32(UpDownRepCountCH1.Value);
                    //_coreChart1._inspectionWorkersCount = Convert.ToInt32(UpDownInspCH1.Value);
                    //_coreChart1._technicWorkersCount = i;

                    _isRunningChart1 = true;
                    _coreChart1.SimulateAsync(repCount);
                }
            }
            _chartModel1.Clear();
        }
        private void buttonStopChart1_Click(object sender, EventArgs e)
        {
            if (_isRunningChart1)
            {
                _coreChart1.StopSimulation();
            }
        }
        private void buttonRunChart2_Click(object sender, EventArgs e)
        {
            if (!_isRunningChart2)
            {
                for (int i = 10; i < 26; i++)
                {
                    var repCount = Convert.ToInt32(UpDownRepCountCH2.Value);
                    //_coreChart2._technicWorkersCount = Convert.ToInt32(UpDownTechCH2.Value);
                    //_coreChart2._inspectionWorkersCount = i;

                    _isRunningChart2 = true;
                    _coreChart2.SimulateAsync(repCount);
                }
            }
            _chartModel2.Clear();
        }

        private void buttonStopChart2_Click(object sender, EventArgs e)
        {
            if (_isRunningChart2)
            {
                _coreChart2.StopSimulation();
            }
        }
    }
}