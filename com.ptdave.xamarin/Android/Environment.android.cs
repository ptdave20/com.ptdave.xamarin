using System;
using System.Collections.Generic;
using System.Text;
using com.ptdave.xamarin.Abstraction;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.OS;

[assembly: Dependency(typeof(com.ptdave.xamarin.EnvironmentAndroid))]
namespace com.ptdave.xamarin
{
    public class EnvironmentAndroid : IEnvironment
    {

        Task<Theme> IEnvironment.GetOperatingSystemThemeAsync()
        {
            if(Build.VERSION.SdkInt >= BuildVersionCodes.Froyo)
            {
                var uiFlags = Helper.activity.ApplicationContext.Resources.Configuration.UiMode;
                switch(uiFlags)
                {
                    case Android.Content.Res.UiMode.NightYes:
                        return Task.FromResult(Theme.Dark);
                    case Android.Content.Res.UiMode.NightNo:
                        return Task.FromResult(Theme.Light);
                    default:
                        return Task.FromResult(Theme.Unknown);
                }
            }
            return Task.FromResult(Theme.Light);
        }
    }
}
