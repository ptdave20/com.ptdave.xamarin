using com.ptdave.xamarin.Abstraction;
using com.ptdave.xamarin.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(EnvironmentIos))]
namespace com.ptdave.xamarin.iOS
{
    public class EnvironmentIos : IEnvironment
    {
        static Task<UIViewController> GetVisibleViewController()
        {
            // UIApplication.SharedApplication can only be referenced on by Main Thread, so we'll use Device.InvokeOnMainThreadAsync which was introduced in Xamarin.Forms v4.2.0
            return Device.InvokeOnMainThreadAsync(() =>
            {
                var rootController = UIApplication.SharedApplication.KeyWindow.RootViewController;

                switch (rootController.PresentedViewController)
                {
                    case UINavigationController navigationController:
                        return navigationController.TopViewController;

                    case UITabBarController tabBarController:
                        return tabBarController.SelectedViewController;

                    case null:
                        return rootController;

                    default:
                        return rootController.PresentedViewController;
                }
            });
        }

        public async Task<Theme> GetOperatingSystemThemeAsync()
        {
            //Ensure the current device is running 12.0 or higher, because `TraitCollection.UserInterfaceStyle` was introduced in iOS 12.0
            if (UIDevice.CurrentDevice.CheckSystemVersion(12, 0))
            {
                var currentUIViewController = await GetVisibleViewController();

                var userInterfaceStyle = currentUIViewController.TraitCollection.UserInterfaceStyle;

                switch (userInterfaceStyle)
                {
                    case UIUserInterfaceStyle.Light:
                        return Theme.Light;
                    case UIUserInterfaceStyle.Dark:
                        return Theme.Dark;
                    default:
                        throw new NotSupportedException($"UIUserInterfaceStyle {userInterfaceStyle} not supported");
                }
            }
            else
            {
                return Theme.Light;
            }
        }
    }
}
