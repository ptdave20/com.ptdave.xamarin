using Android.App;
using Android.OS;
using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin
{
    public static class Helper
    {
        public static Activity activity { get; set; }
        public static Bundle bundle = null;
        public static void Initialize(Activity activity, Bundle bundle)
        {
            Helper.activity = activity;
            Helper.bundle = bundle;
            DependencyService.Register<FileHelper>();
            DependencyService.Register<EnvironmentAndroid>();
        }

    }
}
