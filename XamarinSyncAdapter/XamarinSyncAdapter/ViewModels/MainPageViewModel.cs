using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinSyncAdapter.Interface;

namespace XamarinSyncAdapter.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Sync Adapter";

            //Xamarin.Forms.DependencyService.Get<ISyncManager>().SyncLocalData();
        }
    }
}
