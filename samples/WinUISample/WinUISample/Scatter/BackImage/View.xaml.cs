using System.Linq;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.WinUI;
using Microsoft.UI.Xaml.Controls;

namespace WinUISample.Scatter.BackImage;

public sealed partial class View : UserControl
{
    public View()
    {
        InitializeComponent();
        
        var chartControl = (CartesianChart)FindName("chartControl");
        var axis = chartControl.XAxes.ToList()[0];
        axis.MaxLimit = 0.8f;
        axis.MinLimit = 0.0f;

        axis = chartControl.YAxes.ToList()[0];
        axis.MaxLimit = 0.8f;
        axis.MinLimit = 0.0f;


    }
}
