using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.test.ViewModels
{
    public class EnvironmentModel : INotifyPropertyChanged
    {
        public EnvironmentModel()
        {
            IEnvironment env = DependencyService.Get<IEnvironment>();
            var req = env.GetOperatingSystemThemeAsync();
            req.Wait();
            switch(req.Result)
            {
                case Theme.Dark:
                    IsDarkMode = true;
                    IsLightMode = false;
                    IsUnknown = false;
                    break;
                case Theme.Light:
                    IsDarkMode = false;
                    IsLightMode = true;
                    IsUnknown = false;
                    break;
                case Theme.Unknown:
                    IsDarkMode = false;
                    IsLightMode = false;
                    IsUnknown = true;
                    break;
            }
        }
        public bool IsDarkMode { get; set; }
        public bool IsLightMode { get; set; }
        public bool IsUnknown { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
