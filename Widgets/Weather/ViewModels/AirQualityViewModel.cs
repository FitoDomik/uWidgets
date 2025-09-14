using ReactiveUI;
using uWidgets.Services;
using Weather.Models;
using Weather.Services;

namespace Weather.ViewModels;

public class AirQualityViewModel : ReactiveObject, IDisposable
{
    private readonly ForecastModel model;
    private readonly OpenMeteoWeatherProvider provider;

    public AirQualityViewModel(ForecastModel model)
    {
        provider = new OpenMeteoWeatherProvider();
        this.model = model;
        TimerService.Timer1Hour.Subscribe(UpdateForecast);
        UpdateForecast();
    }
    
    private void UpdateForecast() => _ = UpdateForecastAsync();

    private async Task UpdateForecastAsync()
    {
        var forecast = await provider.GetAirQualityAsync(model.Latitude, model.Longitude);
        if (forecast?.Current == null) return;
        Metric = new(0, 100, forecast.Current.AirQualityIndex, WeatherIcon.Wind.Value);
    }
    
    private MetricViewModel metric = new(0, 100, 0, null);
    public MetricViewModel Metric
    {
        get => metric;
        private set => this.RaiseAndSetIfChanged(ref metric, value);
    }
    
    public void Dispose()
    {
        TimerService.Timer1Hour.Unsubscribe(UpdateForecast);
        GC.SuppressFinalize(this);
    }
}