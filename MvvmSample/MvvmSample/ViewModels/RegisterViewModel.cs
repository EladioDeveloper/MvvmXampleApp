using MvvmSample.Services;
using MvvmSample.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public ICommand RegisterCommand { get; }

        public RegisterViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            await NavigationService.NavigateAsync(new HomePage());
        }
    }
}
