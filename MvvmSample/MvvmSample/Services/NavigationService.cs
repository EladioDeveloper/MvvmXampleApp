﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateAsync(Page page) => App.Current.MainPage.Navigation.PushAsync(page);
    }
}
