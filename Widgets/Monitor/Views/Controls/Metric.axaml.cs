using Avalonia.Controls;

namespace Monitor.Views.Controls;

public partial class Metric : Viewbox
{
    public Metric()
    {
        InitializeComponent();
        // StrokeDashOffset animation causing memory leaks
        // https://github.com/AvaloniaUI/Avalonia/issues/16973
        // 
        // ProgressBar.Transitions = new Transitions
        // {
        //     new DoubleTransition { Property = Shape.StrokeDashOffsetProperty, Duration = TimeSpan.FromMilliseconds(300) }
        // };
    }
}