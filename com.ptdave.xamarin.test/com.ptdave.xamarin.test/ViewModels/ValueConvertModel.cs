using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace com.ptdave.xamarin.test.ViewModels
{
    public class ValueConvertModel : INotifyPropertyChanged
    {
        public bool BoolTest { get; set; } = false;
        public string InputTest { get; set; } = "";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
