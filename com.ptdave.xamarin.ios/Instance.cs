using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.ios
{
    public class Instance
    {
        public static void Initialize()
        {
            DependencyService.Register<FileHelper>();
        }
    }
}
