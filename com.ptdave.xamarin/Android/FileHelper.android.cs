using com.ptdave.xamarin;
using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace com.ptdave.xamarin
{
    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {

        }
        public string DatabaseFile(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}
