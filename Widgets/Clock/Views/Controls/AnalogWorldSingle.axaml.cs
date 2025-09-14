using Avalonia.Controls;
using Clock.Models;
using Clock.ViewModels;

namespace Clock.Views.Controls;

public partial class AnalogWorldSingle : UserControl
{
    public AnalogWorldSingle() : this(new ClockModel()) {}
    
    public AnalogWorldSingle(ClockModel clockModel)
    {
        DataContext = new AnalogClockViewModel(clockModel);
        Unloaded += (_, _) => ((AnalogClockViewModel)DataContext).Dispose();
        InitializeComponent();
    }
}