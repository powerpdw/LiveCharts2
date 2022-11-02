using System.Collections.Generic;
using System.Linq;
using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinUI;
using Microsoft.UI.Xaml.Controls;
using SkiaSharp;

namespace WinUISample.Scatter.BackImage;

public sealed partial class View : UserControl
{
    public View()
    {
        InitializeComponent();
        var chartControl = (CartesianChart)FindName("chartControl");
        List<ICartesianAxis> XAxes = new List<ICartesianAxis>
        {
            new Axis
            {
                Name = "X",
                //NamePaint= new SolidColorPaintTask { Color = SKColors.Gray },
                TextSize = 16,
                MaxLimit = 1,
                MinLimit = 0,
                // LabelsPaint = null will not draw the axis labels.
                //LabelsPaint = new SolidColorPaintTask{ Color = SKColors.Gray },

                // SeparatorsPaint = null will not draw the separator lines
                SeparatorsPaint = new SolidColorPaint{ Color = SKColors.DarkGray, StrokeThickness = 3 },

                Position = LiveChartsCore.Measure.AxisPosition.Start
            }
        };

        List<ICartesianAxis> YAxes = new List<ICartesianAxis>
        {
            new Axis
            {
                Name = "Y",
                //NamePaint= new SolidColorPaintTask { Color = SKColors.Gray },
                TextSize = 16,
                MaxLimit = 1,
                MinLimit = 0,
                //LabelsPaint = new SolidColorPaintTask { Color = SKColors.Gray },
                SeparatorsPaint = new SolidColorPaint{ Color = SKColors.DarkGray, StrokeThickness = 3 },
                Position = LiveChartsCore.Measure.AxisPosition.End
            }
        };

        
        var axis = chartControl.XAxes.ToList()[0];
        axis.MaxLimit = 0.8f;
        axis.MinLimit = 0.0f;

        axis = chartControl.YAxes.ToList()[0];
        axis.MaxLimit = 0.8f;
        axis.MinLimit = 0.0f;


    }
}
