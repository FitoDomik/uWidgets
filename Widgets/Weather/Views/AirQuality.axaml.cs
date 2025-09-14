using Avalonia.Controls;
using Weather.Models;
using Weather.ViewModels;

namespace Weather.Views;

public partial class AirQuality : UserControl
{
    public AirQuality() : this(new ForecastModel("Cupertino", 37.3230, -122.0322, "celsius")) {}

    public AirQuality(ForecastModel model)
    {
        DataContext = new AirQualityViewModel(model);
        InitializeComponent();
    }
}