using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Weather.Views.Controls;

public partial class Metric : UserControl
{
    public Metric()
    {
        SizeChanged += OnSizeChanged;
        Unloaded += OnUnloaded;
        InitializeComponent();
    }

    private void OnUnloaded(object? sender, RoutedEventArgs e)
    {
        SizeChanged -= OnSizeChanged;
        Unloaded -= OnUnloaded;
    }

    private void OnSizeChanged(object? sender, SizeChangedEventArgs e)
    {
        var size = Math.Min(DesiredSize.Width, DesiredSize.Height);
        var margin = size >= 150 ? size * 0.1 : 6;
        Margin = new Thickness(margin, margin);
    }
}