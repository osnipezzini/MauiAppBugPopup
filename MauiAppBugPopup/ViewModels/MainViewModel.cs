using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MauiAppBugPopup.Views;

namespace MauiAppBugPopup.ViewModels;

[ObservableObject]
public partial class MainViewModel
{
    [RelayCommand]
    async Task TestLoad()
    {
        var load = new SOLoading();
        Application.Current.MainPage.ShowPopup(load);
        await Task.Delay(1500);
        load.UpdateMessage("Loading more ...");
        await Task.Delay(2500);
        load.Close();
    }
}
