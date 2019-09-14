using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using Xplat.Views;

namespace Xplat.ViewModels
{
    public sealed class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
                    
        }
    }
}
