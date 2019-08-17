using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace com.ptdave.xamarin.test.ViewModels
{
    public class FileHelperModel : INotifyPropertyChanged
    {
        public string Path { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
