using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Weather.Models;
using Weather.ViewModels;

namespace Weather.Views;

public partial class Pressure : UserControl
{
    public Pressure() : this(new ForecastModel("Cupertino", 37.3230, -122.0322, "celsius")) {}

    public Pressure(ForecastModel model)
    {
        DataContext = new ForecastViewModel(model);
        InitializeComponent();
    }
}