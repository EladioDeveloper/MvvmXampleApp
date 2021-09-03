using MvvmSample.Services;
using MvvmSample.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    public  class LoginViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; }
        public ICommand GoToRegisterCommand { get; }
        public LoginViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            LoginCommand = new Command(OnLogin);
            GoToRegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister(object obj)
        {
            await NavigationService.NavigateAsync(new RegisterPage());
        }

        private async void OnLogin(object obj)
        {
            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await AlertService.AlertAsync("Alerta", "Campos Vacios");
            }
            else
            {
                await AlertService.AlertAsync("Hola", $"{Username}");
                await NavigationService.NavigateAsync(new HomePage());
            }
        }
    }
}
