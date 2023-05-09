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
        public ChartModelWorkers _chartModel2 { get; set; }
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
            _coreChart1.AgentSTK.AktivovatPrestavky = true;
            cartesianChart1.Series = _chartModel1._series;
            cartesianChart1.XAxes = _chartModel1._xAxes;
            cartesianChart1.YAxes = _chartModel1._yAxes;
            _chartModel1.RenameX("Pocet technikov");
            _chartModel1.RenameY("Priemerny pocet vozidiel na parkovisku");
            _coreChart1.OnSimulationDidFinish(OnUpdateChart1);

            _coreChart2 = new MySimulation();
            _coreChart2.AgentSTK.AktivovatPrestavky = true;
            buttonStopChart2.Enabled = false;
            _chartModel2 = new ChartModelWorkers();
            cartesianChart2.Series = _chartModel2._series;
            cartesianChart2.XAxes = _chartModel2._xAxes;
            cartesianChart2.YAxes = _chartModel2._yAxes;
            _chartModel2.RenameX("Pocet automechanikov(Typ1/Typ2)");
            _chartModel2.RenameY("Priemerny cas v systeme(minuty)");
            _coreChart2.OnSimulationDidFinish(OnUpdateChart2);
        }

        private void OnUpdateChart1(Simulation obj)
        {
            _chartModel1.Add(new(_coreChart1.AgentTechnici.PocetTechnikov,
                _coreChart1.DlzkaRadyPrevzatie.GetResult()));
        }

        private void OnUpdateChart2(Simulation obj)
        {
            _chartModel2.Add(new(_coreChart2.AgentAutomechanici.PocetAutomechanikovTyp1,
                _coreChart2.AgentAutomechanici.PocetAutomechanikovTyp2,
                _coreChart2.CasVSysteme.GetResult() / 60));
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

            RefreshGlobalStat();

            if (checkBoxCSV.Checked)
            {
                ExportToCSV();
            }

            Invoke((System.Action)(() =>
            {
                buttonRun.Enabled = true;
                NastaveniaSimulácie.Enabled = true;
                DalsieNastavenia.Enabled = true;
                PocetTechnikov.Enabled = true;
            }));
        }

        private void ExportToCSV()
        {
            // Sample data to append
            string[] newRow = {
                _core.CurrentReplication.ToString(),
                _core.AgentTechnici.PocetTechnikov.ToString(),
                _core.AgentAutomechanici.PocetAutomechanikovTyp1.ToString(),
                _core.AgentAutomechanici.PocetAutomechanikovTyp2.ToString(),
                _core.PocetVozidielVSysteme.GetResult().ToString(),
                _core.PocetVozidielVSysteme.ConfidenceInterval(95).ToString(),
                _core.PocetVozidielNaKonciDna.GetResult().ToString(),
                _core.CasVSysteme.GetResult().ToString(),
                _core.CasVSysteme.ConfidenceInterval(90).ToString(),
                _core.CasCakaniaPrevzatie.GetResult().ToString(),
                _core.DlzkaRadyPrevzatie.GetResult().ToString(),
                _core.VytazenieTechnici.GetResult().ToString(),
                _core.VytazenieAutomechaniciTyp1.GetResult().ToString(),
                _core.VytazenieAutomechaniciTyp2.GetResult().ToString(),
            };

            string csvFilePath = "..\\..\\..\\data.csv";

            // Check if the file exists
            bool fileExists = File.Exists(csvFilePath);

            // Open the file in append mode
            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            {
                // Write headers if the file doesn't exist
                if (!fileExists)
                {
                    string[] headers = {
                        "Pocet replikacii",
                        "Pocet technikov",
                        "Pocet automechanikov typ 1",
                        "Pocet automechanikov typ 2",
                        "Pocet vozidiel v systeme",
                        "Pocet vozidiel v systeme IS",
                        "Pocet vozidel na konci dna",
                        "Cas v systeme",
                        "Cas v systeme IS",
                        "Cakanie na prevzatie",
                        "Dlzka rady",
                        "Volni technici",
                        "Volni automechanici typ 1",
                        "Volni automechanici typ 2", };
                    writer.WriteLine(string.Join(";", headers));
                }

                // Write the new row
                writer.WriteLine(string.Join(";", newRow));
            }
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

                //Vytayenost technici
                var dataGridViewRowTechnical = new DataGridViewRow();
                dataGridViewRowTechnical.CreateCells(dataGridViewLocal, "Volni technici", _core.AgentTechnici.VytazenostTechnici.GetResult(), "technikov");
                dataGridViewLocal.Rows.Add(dataGridViewRowTechnical);

                //Vytazenost automechanic
                var dataGridViewRowInspection1 = new DataGridViewRow();
                dataGridViewRowInspection1.CreateCells(dataGridViewLocal, "Volni automechanici typ 1", _core.AgentAutomechanici.VytazenostAutomechanikovTyp1.GetResult(), "automechnikov");
                dataGridViewLocal.Rows.Add(dataGridViewRowInspection1);
                var dataGridViewRowInspection2 = new DataGridViewRow();
                dataGridViewRowInspection2.CreateCells(dataGridViewLocal, "Volni automechanici typ 2", _core.AgentAutomechanici.VytazenostAutomechanikovTyp2.GetResult(), "automechnikov");
                dataGridViewLocal.Rows.Add(dataGridViewRowInspection2);

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
                textBoxIns.Text = (_core.AgentAutomechanici.VolniAutomechaniciTyp1.Count).ToString() + "/" +
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
            RefreshGlobalStat();
        }
        private void RefreshGlobalStat()
        {
            //Local clear
            ClearLocalStat();
            if ((_core.CurrentReplication % UpDownRepRefresh.Value) == 0 || _isRunning == false)
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

                    //Vytazenie technici
                    var dataGridViewRowTechnical = new DataGridViewRow();
                    dataGridViewRowTechnical.CreateCells(dataGridViewGlobal, "Volni technici", _core.VytazenieTechnici.GetResult(), "technikov");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowTechnical);

                    //Vytazenie automechani
                    var dataGridViewRowInspection1 = new DataGridViewRow();
                    dataGridViewRowInspection1.CreateCells(dataGridViewGlobal, "Volni automechanici typ 1", _core.VytazenieAutomechaniciTyp1.GetResult(), "automechanikov");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowInspection1);
                    var dataGridViewRowInspection2 = new DataGridViewRow();
                    dataGridViewRowInspection2.CreateCells(dataGridViewGlobal, "Volni automechanici typ 2", _core.VytazenieAutomechaniciTyp2.GetResult(), "automechanikov");
                    dataGridViewGlobal.Rows.Add(dataGridViewRowInspection2);
                }));
            }
        }
        private void OnReplicationWillStart(Simulation obj)
        {

        }
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            panelRychlost.Enabled = true;
            SetNormalSpeed();
        }
        private void SetNormalSpeed()
        {
            _core.SetSimSpeed(Convert.ToDouble(UpDownRefresh.Value), Convert.ToDouble(UpDownSpeed.Value));
        }
        private void ClearLocalStat()
        {
            Invoke((System.Action)(() =>
            {
                dataGridViewArrivalQueue.Rows.Clear();
                dataGridViewLocal.Rows.Clear();
                dataGridViewPaymentParking.Rows.Clear();
                dataGridViewInspectionParking.Rows.Clear();
                dataGridViewWorkersIns.Rows.Clear();
                dataGridViewWorkersTech.Rows.Clear();
            }));
        }
        private void buttonTurbo_Click(object sender, EventArgs e)
        {
            _core.SetMaxSimSpeed();
            ClearLocalStat();
            textBoxActualTime.Text = string.Empty;
            textBoxIns.Text = string.Empty;
            textBoxTechnical.Text = string.Empty;
            textBoxInsP.Text = string.Empty;
            textBoxPayment.Text = string.Empty;
            textBoxArrival.Text = string.Empty;

            panelRychlost.Enabled = false;
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            //Simulation is paused
            if (!_isRunning)
            {
                var pocetReplikacii = Convert.ToInt32(UpDownRepCount.Value);
                var automechaniciTyp1 = checkAutomechaniciTyp1.Checked;
                var pocetAutomechanikovTyp1 = Convert.ToInt32(AutomechaniciTyp1.Value);
                var pocetAutomechanikovTyp2 = Convert.ToInt32(AutomechaniciTyp2.Value);
                var pocetTechnikov = Convert.ToInt32(technici.Value);
                var prestavky = checkPrestavky.Checked;

                _isRunning = true;
                if (automechaniciTyp1)
                {
                    _core.AgentAutomechanici.PocetAutomechanikovTyp1 = pocetAutomechanikovTyp1;
                }
                else
                {
                    _core.AgentAutomechanici.PocetAutomechanikovTyp1 = 0;
                }
                _core.AgentAutomechanici.PocetAutomechanikovTyp2 = pocetAutomechanikovTyp2;
                _core.AgentTechnici.PocetTechnikov = pocetTechnikov;
                _core.AgentSTK.AktivovatPrestavky = prestavky;

                _core.SimulateAsync(pocetReplikacii, 8 * 60 * 60);
                SetNormalSpeed();

                buttonRun.Enabled = false;
                NastaveniaSimulácie.Enabled = false;
                DalsieNastavenia.Enabled = false;
                PocetTechnikov.Enabled = false;
                panelRychlost.Enabled = true;
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _core.StopSimulation();
                _isRunning = false;
                buttonRun.Enabled = true;
                NastaveniaSimulácie.Enabled = true;
                DalsieNastavenia.Enabled = true;
                PocetTechnikov.Enabled = true;
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutomechaniciTyp1.Checked == true)
            {
                AutomechaniciTyp1.Enabled = true;
                _core.AgentAutomechanici.PocetAutomechanikovTyp1 = (int)AutomechaniciTyp1.Value;
                _core.AgentAutomechanici.PocetAutomechanikovTyp2 = (int)AutomechaniciTyp2.Value;
            }
            else
            {
                AutomechaniciTyp1.Enabled = false;
                _core.AgentAutomechanici.PocetAutomechanikovTyp1 = 0;
                _core.AgentAutomechanici.PocetAutomechanikovTyp2 = (int)AutomechaniciTyp2.Value;
            }
        }

        private void AutomechaniciTyp2_ValueChanged(object sender, EventArgs e)
        {
            _core.AgentAutomechanici.PocetAutomechanikovTyp2 = (int)AutomechaniciTyp2.Value;
        }

        private void AutomechaniciTyp1_ValueChanged(object sender, EventArgs e)
        {
            _core.AgentAutomechanici.PocetAutomechanikovTyp1 = (int)AutomechaniciTyp1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _core.AgentOkolia.ZrychleniePrichodu = checkBoxZrychlenie.Checked;
        }

        private async void buttonRunChart1_Click_1(object sender, EventArgs e)
        {
            if (!_isRunningChart1)
            {
                _chartModel1.Clear();
                _isRunningChart1 = true;

                var repCount = Convert.ToInt32(RepCountCH1.Value);

                AutemchaniciTyp1CH1.Enabled = false;
                AutemchaniciTyp2CH1.Enabled = false;
                RepCountCH1.Enabled = false;
                buttonRunChart1.Enabled = false;
                buttonStopChart1.Enabled = true;

                _coreChart1.AgentAutomechanici.PocetAutomechanikovTyp1 = Convert.ToInt32(AutemchaniciTyp1CH1.Value);
                _coreChart1.AgentAutomechanici.PocetAutomechanikovTyp2 = Convert.ToInt32(AutemchaniciTyp2CH1.Value);
                for (int i = 1; i < 16; i++)
                {
                    _coreChart1.AgentTechnici.PocetTechnikov = i;

                    if (_isRunningChart1)
                    {
                        await Task.Run(() => _coreChart1.Simulate(repCount));
                    }
                }
                StopChart1();
            }
        }

        private void StopChart1()
        {
            _isRunningChart1 = false;

            AutemchaniciTyp1CH1.Enabled = true;
            AutemchaniciTyp2CH1.Enabled = true;
            RepCountCH1.Enabled = true;
            buttonRunChart1.Enabled = true;
            buttonStopChart1.Enabled = false;
        }

        private void buttonStopChart1_Click(object sender, EventArgs e)
        {
            if (_isRunningChart1)
            {
                _coreChart1.StopSimulation();

                StopChart1();
            }
        }

        private async void buttonRunChart2_Click(object sender, EventArgs e)
        {
            if (!_isRunningChart2)
            {
                _chartModel2.Clear();
                _isRunningChart2 = true;

                var repCount = Convert.ToInt32(UpDownRepCountCH2.Value);

                UpDownRepCountCH2.Enabled = false;
                UpDownTechCH2.Enabled = false;
                buttonRunChart2.Enabled = false;
                buttonStopChart2.Enabled = true;

                _coreChart2.AgentTechnici.PocetTechnikov = Convert.ToInt32(UpDownTechCH2.Value);
                for (int i = 10; i < 26; i++)
                {
                    _coreChart2.AgentAutomechanici.PocetAutomechanikovTyp1 = i;
                    for (int j = 10; j < 26; j++)
                    {
                        _coreChart2.AgentAutomechanici.PocetAutomechanikovTyp2 = j;
                        if (_isRunningChart2)
                        {
                            await Task.Run(() => _coreChart2.Simulate(repCount));
                        }
                    }
                }
                StopChart2();
            }
        }

        private void StopChart2()
        {
            _isRunningChart2 = false;

            UpDownRepCountCH2.Enabled = true;
            UpDownTechCH2.Enabled = true;
            buttonRunChart2.Enabled = true;
            buttonStopChart2.Enabled = false;
        }

        private void buttonStopChart2_Click(object sender, EventArgs e)
        {
            if (_isRunningChart2)
            {
                _coreChart2.StopSimulation();
                StopChart2();
            }
        }
    }
}