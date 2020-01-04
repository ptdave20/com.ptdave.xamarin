using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace com.ptdave.xamarin.test.ViewModels
{
    public class ValueConvertModel : INotifyPropertyChanged
    {
        public ValueConvertModel()
        {
            EmptyCollection = new ObservableCollection<int>();
            HasItems = new ObservableCollection<int>(new int[] { 1, 2, 4, 5 });
        }
        public bool BoolTest { get; set; } = false;
        public string InputTest { get; set; } = "";

        public ObservableCollection<int> EmptyCollection { get; set; }
        public ObservableCollection<int> HasItems { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
        public DateTimeOffset DateOffset { get; set; } = DateTimeOffset.UtcNow;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
