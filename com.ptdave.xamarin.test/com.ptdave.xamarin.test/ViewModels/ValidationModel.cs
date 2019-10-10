using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace com.ptdave.xamarin.test.ViewModels
{
    public class ValidationModel : INotifyPropertyChanged
    {
        [StringLength(100,ErrorMessage = "Must be within 3 and 100 characters", MinimumLength = 3)]
        public string Test { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
