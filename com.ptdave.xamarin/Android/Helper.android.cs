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
        static Activity activity = null;
        static Bundle bundle = null;
        public static void Initialize(Activity activity, Bundle bundle)
        {
            DependencyService.Register<FileHelper>();
        }
    }
}
