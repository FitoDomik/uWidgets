using Avalonia.Controls;
using Avalonia.Interactivity;
using Monitor.Models;
using Monitor.ViewModels;

namespace Monitor.Views;

public partial class SingleMetric : UserControl
{
    public SingleMetric() :
        this(new SingleMetricModel(MetricType.CpuUsage)) {}
    
    public SingleMetric(SingleMetricModel model)
    {
        DataContext = new SingleMetricViewModel(model);
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
        const int smallSize = 100;
        var small = e.NewSize is { Height: < smallSize };
        
        Grid.RowDefinitions = RowDefinitions.Parse(small ? "*" : "*,*");
        Grid.SetRow(Text, small ? 0 : 1);
        Text.IsVisible = !small;
        Margin = new(small ? 6 : 12);
    }
}