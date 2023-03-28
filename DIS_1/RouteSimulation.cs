using DIS.Distributions;
using DIS.SimulationCores;
using DIS.SimulationCores.RouteSimulation;
using DIS.SimulationCores.Statistics;
using DIS_1.ChartModels;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using System.Collections.ObjectModel;
using static System.Windows.Forms.AxHost;
using System.Net.NetworkInformation;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace DIS_1
{
    public partial class RouteSimulation : Form
    {
        public SimulationCore? _core { get; set; }
        public ChartModel _chartModel { get; set; }
        public RouteSimulation()
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
        }
        private void buttonRouteA_Click(object sender, EventArgs e)
        {
            var repCount = Convert.ToInt32(textBoxRepCount.Text);            

            _chartModel.RenameY("Waitning time / minutes");
            _core = new RouteCoreA(repCount);

            RunSimulation();
        }
        private void buttonRouteB_Click(object sender, EventArgs e)
        {
            var repCount = Convert.ToInt32(textBoxRepCount.Text);

            _chartModel.RenameY("Probability of arriving on time");
            _core = new RouteCoreB(repCount);

            RunSimulation();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(_core != null)
            {
                _core._stopSimulation = true;
            }            
        }
        private async void RunSimulation()
        {
            buttonRouteA.Enabled = false;
            buttonRouteB.Enabled = false;

            _chartModel.Clear();
            textBoxResult.Text = "0";

            var dataCount = Convert.ToInt32(textBoxDataCount.Text);
            var ignore = Convert.ToInt32(textBoxIgnore.Text);

            if(_core != null)
            {
                _core._dataUpdate += UpdateData;
                _core._dataGenerate = dataCount;
                _core._ignore = ignore;

            }            

            await Task.Run(() =>
            {
                _core?.RunSimulation();
            });            

            buttonRouteA.Enabled = true;
            buttonRouteB.Enabled = true;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (_core._globalStatistics.TryGetValue("waitingTime", out Statistic statistic))
            {
                var normalStatistic = (NormalStatistic)statistic;
                var result = normalStatistic.GetResult();

                BeginInvoke(new Action(() =>
                {
                    textBoxResult.Text = result.ToString();
                    _chartModel.Add(new(_core?._actualRepCount, result));
                }));
            }
            
        }
    }
}