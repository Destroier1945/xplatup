﻿using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using Xplat.Views;

namespace Xplat.ViewModels
{
    class NewCollectionPageViewModel : ViewModelBase
    {
        public NewCollectionPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
        }
    }
}
