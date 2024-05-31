using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xplat.Views;

namespace Xplat.ViewModels
{
    public sealed class HomePageViewModel : ViewModelBase
    {
        private string title;

        public HomePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Collectors App";
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}
