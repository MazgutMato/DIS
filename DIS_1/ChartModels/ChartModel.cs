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
    public class ChartModel
    {
        protected static readonly SKColor s_gray = new(195, 195, 195);
        protected static readonly SKColor s_gray1 = new(160, 160, 160);
        protected static readonly SKColor s_gray2 = new(90, 90, 90);
        protected static readonly SKColor s_dark3 = new(60, 60, 60);
        protected static readonly SKColor s_black = new(0, 0, 0);
        protected static readonly SKColor s_crosshair = new(255, 171, 145);
        public ObservableCollection<ObservablePoint> _values { get; set; }
        public ObservableCollection<ISeries> _series { get; set; }
        public Axis[] _xAxes { get; set; }
        public Axis[] _yAxes { get; set; }
        public ChartModel()
        {
            _values = new ObservableCollection<ObservablePoint>();

            _series = new ObservableCollection<ISeries>()
            {
                new LineSeries<ObservablePoint>
                {
                    Values = _values,
                    Fill = null,
                    //GeometrySize = 0,
                    LineSmoothness = 0,
                    TooltipLabelFormatter =
                        (chartPoint) => $"{chartPoint.PrimaryValue}"
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

        public void Add(ObservablePoint point)
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
