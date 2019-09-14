using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using Xplat.Views;

namespace Xplat.ViewModels
{
    public sealed class CollectionPageViewModel : ViewModelBase
    {
        public CollectionPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
        }
    }
}
