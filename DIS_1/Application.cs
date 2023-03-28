using DIS.SimulationCores;
using DIS.SimulationCores.RouteSimulation;
using DIS.SimulationCores.Statistics;
using DIS_1.ChartModels;
using DIS.SimulationCores.NewsSimulation;
using System.Collections;
using static System.Windows.Forms.AxHost;

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
            textBoxActualRep.Invoke((MethodInvoker)delegate ()
            {
                textBoxActualRep.Text = _core._actualRepCount.ToString();
            });

            dataGridViewGlobal.Invoke((MethodInvoker)delegate ()
            {
                foreach (var item in _core._globalStatistics)
                {
                    var key = item.Key.ToString();
                    var stat = item.Value;

                    // Check if a row with the key already exists in the control
                    DataGridViewRow dataGridViewRow = dataGridViewGlobal.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == key);

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
                _core = new NewsStand(repCount, 10000);
            }
            else
            {
                return;
            }

            buttonRun.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;

            RunSimulation();
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

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _core._pause = true;
            buttonRun.Enabled = true;
        }
    }
}