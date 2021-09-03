using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSample.Services
{
    public class AlertService : IAlertService
    {
        public Task AlertAsync(string title, string description) => App.Current.MainPage.DisplayAlert(title, description, "OK");
    }
}
