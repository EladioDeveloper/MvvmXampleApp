using MvvmSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmSample.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel(IAlertService alertService, INavigationService navigationService)
        {
            AlertService = alertService;
            NavigationService = navigationService;
        }

        protected IAlertService AlertService { get; }
        protected INavigationService NavigationService { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
