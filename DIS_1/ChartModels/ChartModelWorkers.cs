using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;

namespace DIS_1.ChartModels
{
    public class WorkersSet
    {
        public int Type1Count { get; set; }
        public int Type2Count { get; set; }
        public double Value { get; set; }
        public WorkersSet(int type1Count, int type2Count, double value)
        {
            Type1Count = type1Count;
            Type2Count = type2Count;
            Value = value;
        }
    }
    public class ChartModelWorkers
    {
        protected static readonly SKColor s_gray = new(195, 195, 195);
        protected static readonly SKColor s_gray1 = new(160, 160, 160);
        protected static readonly SKColor s_gray2 = new(90, 90, 90);
        protected static readonly SKColor s_dark3 = new(60, 60, 60);
        protected static readonly SKColor s_black = new(0, 0, 0);
        protected static readonly SKColor s_crosshair = new(255, 171, 145);
        public bool _info = false;
        public ObservableCollection<WorkersSet> _values { get; set; }
        public ObservableCollection<ISeries> _series { get; set; }
        public Axis[] _xAxes { get; set; }
        public Axis[] _yAxes { get; set; }
        public ChartModelWorkers()
        {
            _values = new ObservableCollection<WorkersSet>();

            _series = new ObservableCollection<ISeries>()
            {
                new LineSeries<WorkersSet>
                {
                    Values = _values,
                    Mapping = (workerSet, point) =>
                    {
                        point.PrimaryValue = workerSet.Value;
                        point.SecondaryValue = point.Context.Index;
                    },
                    Fill = null,
                    GeometrySize = 0,
                    LineSmoothness = 0,
                    TooltipLabelFormatter =
                        (chartPoint) => $"Automechanici: {chartPoint.Model.Type1Count}/{chartPoint.Model.Type2Count} Cas: {chartPoint.PrimaryValue}",                   
                    //DataLabelsSize = 10,
                    //DataLabelsPaint = new SolidColorPaint
                    //{
                    //    Color = s_black,
                    //},
                    //DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                    //DataLabelsFormatter  =
                    //    (chartPoint) => $"{chartPoint.Model.Type1Count}/{chartPoint.Model.Type2Count}",
                }
            };
            _xAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Replication Count",
                    NamePaint = new SolidColorPaint(s_black),
                    TextSize = 18,
                    Padding = new LiveChartsCore.Drawing.Padding(5, 15, 5, 5),
                    SeparatorsPaint = new SolidColorPaint
                        {
                            Color = s_gray,
                            StrokeThickness = 1,
                        }
                }

            };
            _yAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Waiting time",
                    NamePaint = new SolidColorPaint(s_black),
                    TextSize = 18,
                    Padding = new LiveChartsCore.Drawing.Padding(5, 0, 15, 0),
                    LabelsPaint = new SolidColorPaint(s_black),
                    SeparatorsPaint = new SolidColorPaint
                        {
                            Color = s_gray,
                            StrokeThickness = 1,
                        }
                }
            };
        }

        public void Add(WorkersSet point)
        {
            _values.Add(point);
        }

        public void Clear()
        {
            _values.Clear();
        }

        public void RenameX(string name)
        {
            _xAxes[0].Name = name;
        }

        public void RenameY(string name)
        {
            _yAxes[0].Name = name;
        }
    }
}
