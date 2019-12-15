using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using com.ptdave.xamarin.test.Views;
using com.ptdave.xamarin.Abstraction;

namespace com.ptdave.xamarin.test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected async override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
