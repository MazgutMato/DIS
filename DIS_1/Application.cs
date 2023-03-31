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
        public Application()
        {
            InitializeComponent();

            _chartModel = new ChartModel();
            cartesianChart1.Series = _chartModel._series;
            cartesianChart1.XAxes = _chartModel._xAxes;
            cartesianChart1.YAxes = _chartModel._yAxes;
            _chartModel.RenameX("Replication count");

            textBoxRepCount.Text = "1000000";
            textBoxDataCount.Text = "1000";
            textBoxIgnore.Text = "30";
            trackBarSpeed.Value = 1;
            textBoxSpeed.Text = "1";

            buttonNormal.Enabled = false;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
        }
        private async void RunSimulation()
        {
            comboBoxProject.Enabled = false;

            _chartModel.Clear();
            textBoxActualRep.Text = "0";

            var dataCount = Convert.ToInt32(textBoxDataCount.Text);
            var ignore = Convert.ToInt32(textBoxIgnore.Text);

            if (_core != null)
            {
                _core._dataUpdate += UpdateData;
                _core._dataGenerate = dataCount;
                _core._ignore = ignore;

            }

            await Task.Run(() =>
            {
                _core?.RunSimulation();
            });

            _core = null;
            comboBoxProject.Enabled = true;
            buttonRun.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            //Local update
            if(_core is EventCore)
            {
                var core = (EventCore)_core;
                textBoxActualTime.Invoke((MethodInvoker)delegate ()
                {
                    textBoxActualTime.Text = core._actualTime.ToString();
                });

                dataGridViewLocal.Invoke((MethodInvoker)delegate ()
                {
                    var statCount = 1;
                    foreach (var item in _core._localStatistic)
                    {
                        var key = statCount;
                        var stat = item;

                        // Check if a row with the key already exists in the control
                        DataGridViewRow dataGridViewRow = dataGridViewLocal.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == key.ToString());

                        if (dataGridViewRow == null)
                        {
                            // Create a new row and add it to the control
                            dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(dataGridViewLocal, key, stat.GetResult());
                            dataGridViewLocal.Rows.Add(dataGridViewRow);
                        }
                        else
                        {
                            // Update the value of the existing row
                            dataGridViewRow.Cells[1].Value = stat.GetResult();
                        }
                        statCount++;
                    }
                });
            }

            //GlobalUpdate
            textBoxActualRep.Invoke((MethodInvoker)delegate ()
            {
                textBoxActualRep.Text = _core._actualRepCount.ToString();
            });
            dataGridViewGlobal.Invoke((MethodInvoker)delegate ()
            {
                var statCount = 1;
                foreach (var item in _core._globalStatistics)
                {
                    var key = statCount;
                    var stat = item;

                    // Check if a row with the key already exists in the control
                    DataGridViewRow dataGridViewRow = dataGridViewGlobal.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == key.ToString());

                    if (dataGridViewRow == null)
                    {
                        // Create a new row and add it to the control
                        dataGridViewRow = new DataGridViewRow();
                        dataGridViewRow.CreateCells(dataGridViewGlobal, key, stat.GetResult());
                        dataGridViewGlobal.Rows.Add(dataGridViewRow);
                    }
                    else
                    {
                        // Update the value of the existing row
                        dataGridViewRow.Cells[1].Value = stat.GetResult();
                    }
                    statCount++;
                }
            });
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

            if (comboBoxProject.Text == "NewsStand")
            {
                _core = new STKCore(repCount, 10000);
            }
            else
            {
                return;
            }

            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;
            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
            textBoxSpeed.Text = "1";
            trackBarSpeed.Value = 1;

            RunSimulation();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _core._pause = true;
            buttonRun.Enabled = true;
            buttonPause.Enabled = false;
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

        private void buttonTurbo_Click(object sender, EventArgs e)
        {
            if(_core == null || _core is not EventCore)
            {
                return;
            }

            var core = (EventCore)_core;
            core._mode = Mode.TURBO;

            buttonNormal.Enabled = true;
            buttonTurbo.Enabled = false;
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            if (_core == null || _core is not EventCore)
            {
                return;
            }

            var core = (EventCore)_core;
            core._mode = Mode.NORMAL;

            buttonNormal.Enabled = false;
            buttonTurbo.Enabled = true;
        }
    }
}