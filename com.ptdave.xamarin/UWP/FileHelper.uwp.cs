using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.ptdave.xamarin.Abstraction;
using Xamarin.Forms;

[assembly: Dependency(typeof(IFileHelper))]
namespace com.ptdave.xamarin
{
    public class FileHelper : IFileHelper
    {
        public string DatabaseFile(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}
