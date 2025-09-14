namespace uWidgets.Core.Models.Settings;

/// <summary>
/// Application settings, stored in <c>appsettings.json</c>.
/// </summary>
public record AppSettings(
    Theme Theme, 
    Theme[] Templates,
    Layout Layout, 
    Dimensions Dimensions, 
    Region Region, 
    bool RunOnStartup,
    string? IgnoreUpdate);
