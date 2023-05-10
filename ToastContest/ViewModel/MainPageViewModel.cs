using CommunityToolkit.Mvvm.ComponentModel;

namespace ToastContest.ViewModel
{
    public partial class MainPageViewModel: ObservableObject
    {
        public MainPageViewModel()
        {
           
        }
        
        //View model used with Community Tool Kit compiled to general code that usually is seen to get and set
        [ObservableProperty]
        public string selectedVertical;

        [ObservableProperty]
        public string selectedHorizontal;

        [ObservableProperty]
        public string selectedMessageType;

        [ObservableProperty]
        public string message;

        [ObservableProperty]
        public string slider;
    }
}
