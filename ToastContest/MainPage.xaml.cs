using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ToastContest.ViewModel;

namespace ToastContest;

public partial class MainPage : ContentPage
{
	int count = 0;
    public ContentPage cp;
	private readonly MainPageViewModel _vm;

    //on load of the MainPage, the consturctor binds the view model and some data
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

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        //Locations and Anchors for where/how the alert shows up.
        Picker vertical;
        Label horizontal;
        Color color;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        //view model binding variables
        vertical = _vm.SelectedVertical == "Top" ? TypeOfSnackBar: VeritcalLocation;
        horizontal = _vm.SelectedHorizontal == "Left" ? Label1 : Label2;
        color = _vm.SelectedMessageType == "Success" ? Colors.Green : Colors.Red;

        //Alert Snackbar Alert options
        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = color,
            TextColor = Colors.Black,
            ActionButtonTextColor = Colors.Yellow,
            CornerRadius = new CornerRadius(20),
            Font = Microsoft.Maui.Font.SystemFontOfSize(14),
            ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14),
            CharacterSpacing = 0.5
        };

        //Messages for alerts.
        string text = _vm.Message;

        //Do things with the alert once pop up
        string actionButtonText = "Click Here to Dismiss";
        Int32 secs = Convert.ToInt32(Convert.ToDouble(_vm.Slider));
        TimeSpan duration = TimeSpan.FromSeconds(secs);
        Action action = async () => await App.Current.MainPage.DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");

        //Create Snackbar
        var snackbar = Snackbar.Make(text, action, actionButtonText, duration, snackbarOptions, vertical);
        
        //Show it
        await snackbar.Show(cancellationTokenSource.Token);
    }

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		sliderValue.Text = ((int)e.NewValue).ToString();
    }


}

