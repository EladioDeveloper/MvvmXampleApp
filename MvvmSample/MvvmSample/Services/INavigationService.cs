﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample.Services
{
    public interface INavigationService
    {
        Task NavigateAsync(Page page);
    }
}
