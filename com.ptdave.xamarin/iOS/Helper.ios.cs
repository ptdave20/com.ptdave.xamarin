using com.ptdave.xamarin.Abstraction;
using com.ptdave.xamarin.ios;
using com.ptdave.xamarin.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin
{
    public static class Helper
    {
        public static void Initialize()
        {
            DependencyService.Register<IFileHelper,FileHelper>();
            DependencyService.Register<IEnvironment, EnvironmentIos>();
        }
    }
}
