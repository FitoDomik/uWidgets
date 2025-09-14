using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using uWidgets.Core.Interfaces;
using uWidgets.ViewModels;

namespace uWidgets.Views.Pages;

public partial class General : UserControl
{
    public General(IAppSettingsProvider appSettingsProvider)
    {
        DataContext = new GeneralViewModel(appSettingsProvider);
        InitializeComponent();
    }
}