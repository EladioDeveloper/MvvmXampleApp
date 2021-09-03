using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample.Models
{
    public class MenuOption
    {
        public MenuOption(string title, string image)
        {
            Title = title;
            Image = image;
        }

        public string Title { get; set; }
        public string Image { get; set; }
    }
}
