using com.ptdave.xamarin.ios;
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
            DependencyService.Register<FileHelper>();
        }
    }
}
