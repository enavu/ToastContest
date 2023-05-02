using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

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
