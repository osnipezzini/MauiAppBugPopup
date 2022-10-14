using MauiAppBugPopup.ViewModels;

namespace MauiAppBugPopup.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		((MainViewModel)BindingContext).TestLoadCommand.Execute(null);
    }
}

