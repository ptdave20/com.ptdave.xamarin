using com.ptdave.xamarin.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(com.ptdave.xamarin.Services.IFileHelper))]
namespace com.ptdave.xamarin.android.Services
{
    public class FileHelper : IFileHelper
    {
        public string DatabaseFile(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}
