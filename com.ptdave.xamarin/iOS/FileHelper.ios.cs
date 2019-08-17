using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(IFileHelper))]
namespace com.ptdave.xamarin.ios
{
    [Preserve(AllMembers = true)]
    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {

        }
        public string DatabaseFile(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library", filename);
        }
    }
}
