using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;
using ToastContest.ViewModel;

namespace ToastContest;

public partial class MainPage : ContentPage
{
	int count = 0;
	private readonly MainPageViewModel _vm;
	public MainPage()
	{
		BindingContext = _vm = new MainPageViewModel();

		InitializeComponent();
        List<string> TopBottom = new List<string>() { "Top", "Bottom" };
        VeritcalLocation.ItemsSource = TopBottom;
        List<string> LeftRights = new List<string>() { "Left", "Right" };
        HorizontalLocation.ItemsSource = LeftRights;
        List<string> TypeOfNotification = new List<string>() { "Success", "Warning" };
        TypeOfSnackBar.ItemsSource = TypeOfNotification;


    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		sliderValue.Text = ((int)e.NewValue).ToString();
    }

	public async void SetSnackBarSettings(object sender, ValueChangedEventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Green,
            ActionButtonTextColor = Colors.Yellow,
            CornerRadius = new CornerRadius(20),
            Font = Microsoft.Maui.Font.SystemFontOfSize(14),
            ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14),
            CharacterSpacing = 0.5

        };

        string text = "This is a Snackbar";
        string actionButtonText = "Click Here to Dismiss";
        TimeSpan duration = TimeSpan.FromSeconds(10);
        Action action = async () => await App.Current.MainPage.DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");

        var snackbar = Snackbar.Make(text, action, actionButtonText, duration, new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Green,
            ActionButtonTextColor = Colors.Yellow,
            CornerRadius = new CornerRadius(20),
            Font = Microsoft.Maui.Font.SystemFontOfSize(14),
            ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14),
            CharacterSpacing = 0.5

        }, Stuff);

        await snackbar.Show(cancellationTokenSource.Token);

    }
}

