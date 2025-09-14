using Clock.Models;
using ReactiveUI;

namespace Clock.ViewModels;

public class WorldClockViewModel(WorldClockModel worldClockModel) : ReactiveObject, IDisposable
{
    private List<AnalogClockViewModel> ViewModels => Enumerable
        .Range(0, 4)
        .Select(i =>
            new AnalogClockViewModel(new ClockModel(
                false, 
                false,
                false, 
                worldClockModel.TimeZoneIds.ElementAtOrDefault(i))))
        .ToList();

    public AnalogClockViewModel First => ViewModels[0];
    public AnalogClockViewModel Second => ViewModels[1];
    public AnalogClockViewModel Third => ViewModels[2];
    public AnalogClockViewModel Fourth => ViewModels[3];

    public void Dispose()
    {
        ViewModels.ForEach(x => x.Dispose());
        GC.SuppressFinalize(this);
    }
}