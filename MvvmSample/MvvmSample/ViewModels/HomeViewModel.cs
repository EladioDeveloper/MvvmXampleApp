using MvvmSample.Models;
using MvvmSample.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MenuOption Bars { get; }
        public MenuOption Restaurants { get;  }
        public MenuOption Places { get; }
        public MenuOption Offices { get; }

        public HomeViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            Bars = new MenuOption("Bar", "bar");
            Restaurants = new MenuOption("Restaurants", "bar");
            Places = new MenuOption("Places", "bar");
            Offices = new MenuOption("Offices", "bar");
        }
    }
}
