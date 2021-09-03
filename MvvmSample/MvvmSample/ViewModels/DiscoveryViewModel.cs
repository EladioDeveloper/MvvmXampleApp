using MvvmSample.Models;
using MvvmSample.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample.ViewModels
{
    public class DiscoveryViewModel : BaseViewModel
    {
        public MenuOption Bars { get; }
        public MenuOption Restaurants { get;  }
        public MenuOption Places { get; }
        public MenuOption Offices { get; }

        public DiscoveryViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            Bars = new MenuOption("Bar", "Menu");
            Restaurants = new MenuOption("Restaurants", "Menu");
            Places = new MenuOption("Places", "Menu");
            Offices = new MenuOption("Offices", "Menu");
        }
    }
}
