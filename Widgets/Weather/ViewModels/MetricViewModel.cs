using Avalonia.Media;

namespace Weather.ViewModels;

public record MetricViewModel(double Min, double Max, double Value, StreamGeometry? Icon)
{
    public int? DisplayMin => Icon != null ? null : (int)Math.Round(Min);
    public int? DisplayMax => Icon != null ? null : (int)Math.Round(Max);
    public int? DisplayValue => (int)Math.Round(Value);
    public int FontSize => DisplayValue.ToString()?.Length > 2
        ? 50 * 2 / DisplayValue.ToString()?.Length ?? 2
        : 50;
    
    public double StrokeDashOffset => (Math.Clamp(Value, Min, Max) - Min) / (Max - Min) * 21;
}