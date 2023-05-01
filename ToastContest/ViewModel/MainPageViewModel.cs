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
        
        [ObservableProperty]
        public string selectedVertical;
        [ObservableProperty]
        public string selectedHorizontal;
        [ObservableProperty]
        public string selectedMessageType;
    }
}
