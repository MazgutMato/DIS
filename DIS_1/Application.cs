using DIS.SimulationCores;
using DIS_1.ChartModels;
using DIS.SimulationCores.EventSimulation;
using DIS.Models.EventSimulation.STKSimulation;
using OSPABA;
using DIS.Models.AgentSimulation.STKSimulation.simulation;
using DIS.Models.AgentSimulation.STKSimulation.entities;

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

                dataGridViewLocal.Rows.Clear();

                //Vozidla v systeme
                var dataGridViewRowVehicle = new DataGridViewRow();
                dataGridViewRowVehicle.CreateCells(dataGridViewLocal, "Pocet vozidiel v systeme", _core.AgentOkolia.VozidlaVSysteme.GetResult(), "vozidiel");
                dataGridViewLocal.Rows.Add(dataGridViewRowVehicle);

                //Cas v systeme
                var dataGridViewRowSystem = new DataGridViewRow();
                dataGridViewRowSystem.CreateCells(dataGridViewLocal, "Cas v systeme", _core.AgentOkolia.CasVSysteme.GetResult() / 60, "minut");
                dataGridViewLocal.Rows.Add(dataGridViewRowSystem);

                //Cas cakania prevzatie
                var dataGridViewRowWaiting = new DataGridViewRow();
                dataGridViewRowWaiting.CreateCells(dataGridViewLocal, "Cakanie na prevzatie", _core.AgentTechnici.CasCakaniaPrevzatie.GetResult() / 60, "minutes");
                dataGridViewLocal.Rows.Add(dataGridViewRowWaiting);

                //Dlzka rady
                var dataGridViewRowLine = new DataGridViewRow();
                dataGridViewRowLine.CreateCells(dataGridViewLocal, "Dlzka rady", _core.AgentTechnici.DlzkaRadyPrevzatie.GetResult(), "vozidiel");
                dataGridViewLocal.Rows.Add(dataGridViewRowLine);

                ////Free technical
                //var dataGridViewRowTechnical = new DataGridViewRow();
                //dataGridViewRowTechnical.CreateCells(dataGridViewLocal, "Free technical", core._freeTechnicalLocal.GetResult(), "workers");
                //dataGridViewLocal.Rows.Add(dataGridViewRowTechnical);

                ////Free inspection
                //var dataGridViewRowInspection = new DataGridViewRow();
                //dataGridViewRowInspection.CreateCells(dataGridViewLocal, "Free inspection", core._freeInspectionLocal.GetResult(), "workers");
                //dataGridViewLocal.Rows.Add(dataGridViewRowInspection);

                //Arrival line
                textBoxArrival.Text = _core.AgentTechnici.ParkoviskoPrevziate.Count.ToString();
                dataGridViewArrivalQueue.Rows.Clear();
                foreach (var sprava in _core.AgentTechnici.ParkoviskoPrevziate)
                {
                    var arrivalTime = _startTime.AddSeconds(sprava.Vozidlo.CasPrichodu);
                    var outTime = arrivalTime.ToString("HH:mm:ss");
                    // Create a new row and add it to the control
                    var dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewArrivalQueue, sprava.Vozidlo.ID, sprava.Vozidlo.TypVozidla,
                        outTime);
                    dataGridViewArrivalQueue.Rows.Add(dataGridViewRow);
                }

                //Workers INS
                textBoxIns.Text = (_core.AgentAutomechanici.VolniAutomechanici.Count).ToString() + "/" +
                    _core.AgentAutomechanici.VsetciAutomechanici.Count;
                dataGridViewWorkersIns.Rows.Clear();
                foreach (var zamestnanec in _core.AgentAutomechanici.VsetciAutomechanici)
                {
                    var dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewWorkersIns, zamestnanec.ID, zamestnanec.Typ,
                        zamestnanec.Pracuje, zamestnanec.Vozidlo);
                    dataGridViewWorkersIns.Rows.Add(dataGridViewRow);
                }

                //Workers TECH
                textBoxTechnical.Text = _core.AgentTechnici.VolniTechnici.Count + "/" +
                    _core.AgentTechnici.VsetciTechnici.Count;
                dataGridViewWorkersTech.Rows.Clear();
                foreach (var zamestnanec in _core.AgentTechnici.VsetciTechnici)
                {
                    var dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewWorkersIns, zamestnanec.ID, zamestnanec.Typ,
                        zamestnanec.Pracuje, zamestnanec.Vozidlo);
                    dataGridViewWorkersTech.Rows.Add(dataGridViewRow);
                }

                //Inpsection parking
                textBoxInsP.Text = _core.AgentAutomechanici.ParkoviskoKontrola.Count.ToString() + "/5";
                dataGridViewInspectionParking.Rows.Clear();
                foreach (var sprava in _core.AgentAutomechanici.ParkoviskoKontrola)
                {
                    // Create a new row and add it to the control
                    var dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewInspectionParking, sprava.Vozidlo.ID, sprava.Vozidlo.TypVozidla);
                    dataGridViewInspectionParking.Rows.Add(dataGridViewRow);
                }

                //Payment parking
                textBoxPayment.Text = _core.AgentTechnici.ParkoviskoPlatba.Count.ToString();
                dataGridViewPaymentParking.Rows.Clear();
                foreach (var sprava in _core.AgentTechnici.ParkoviskoPlatba)
                {
                    // Create a new row and add it to the control
                    var dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewPaymentParking, sprava.Vozidlo.ID, sprava.Vozidlo.TypVozidla);
                    dataGridViewPaymentParking.Rows.Add(dataGridViewRow);
                }
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

                    dataGridViewGlobal.Rows.Clear();

                    //Vozidla v systeme
                    var dataGridViewRowVehicle = new DataGridViewRow();
                    dataGridViewRowVehicle.CreateCells(dataGridViewGlobal, "Pocet vozidiel v systeme", _core.PocetVozidielVSysteme.GetResult(), "vozidiel");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicle);

                    //Vozidla v systeme
                    var vehicleInIs = _core.PocetVozidielVSysteme.ConfidenceInterval(95);
                    var dataGridViewRowVehicleIS = new DataGridViewRow();
                    dataGridViewRowVehicleIS.CreateCells(dataGridViewGlobal, "Pocet vozidiel v systeme IS", "(" + Math.Round(vehicleInIs.Item1, 5) +
                        " ; " + Math.Round(vehicleInIs.Item2, 5) + ")", "vozidiel");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowVehicleIS);

                    //Vozidla na konci dna
                    var dataGridViewRowEnd = new DataGridViewRow();
                    dataGridViewRowEnd.CreateCells(dataGridViewGlobal, "Pocet na konci dna", _core.PocetVozidielNaKonciDna.GetResult(), "vozidiel");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowEnd);

                    //Cas v systeme
                    var dataGridViewRowSystem = new DataGridViewRow();
                    dataGridViewRowSystem.CreateCells(dataGridViewGlobal, "Cas v systeme", _core.CasVSysteme.GetResult() / 60, "minut");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowSystem);

                    //Cas v systeme IS
                    var timeInIS = _core.CasVSysteme.ConfidenceInterval(90);
                    var dataGridViewRowSystemIS = new DataGridViewRow();
                    dataGridViewRowSystemIS.CreateCells(dataGridViewGlobal, "Cas v systeme IS", "(" + Math.Round(timeInIS.Item1 / 60, 5) +
                        " ; " + Math.Round(timeInIS.Item2 / 60, 5) + ")", "minut");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowSystemIS);

                    //Cakanie na prevzatie
                    var dataGridViewRowWaiting = new DataGridViewRow();
                    dataGridViewRowWaiting.CreateCells(dataGridViewGlobal, "Cakanie na prevzatie", _core.CasCakaniaPrevzatie.GetResult() / 60, "minut");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowWaiting);

                    //Dlzka rady
                    var dataGridViewRowLine = new DataGridViewRow();
                    dataGridViewRowLine.CreateCells(dataGridViewGlobal, "Dlzka rady", _core.DlzkaRadyPrevzatie.GetResult(), "vozidiel");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowLine);

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
                var pocetAutomechanikov = Convert.ToInt32(inspectionWorkers.Value);
                var pocetTechnikov = Convert.ToInt32(technicalWorkers.Value);
                var prestavky = checkPrestavky.Checked;

                _isRunning = true;
                _core.AgentAutomechanici.PocetAutomechanikov = pocetAutomechanikov;
                _core.AgentTechnici.PocetTechnikov = pocetTechnikov;
                _core.AgentSTK.AktivovatPrestavky = prestavky;

                _core.SimulateAsync(pocetReplikacii, 8 * 60 * 60);
                SetNormalSpeed();

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
                    buttonStop.Enabled = false;
                }
                else
                {
                    _isPaused = false;
                    _core.ResumeSimulation();
                    buttonPause.Text = "Pause";
                    buttonStop.Enabled = true;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}