using Android.App;
using Android.OS;
using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.android
{
    public class Instance
    {
        public static void Initialize(Activity activity)
        {
            DependencyService.Register<FileHelper>();
        }
    }
}
