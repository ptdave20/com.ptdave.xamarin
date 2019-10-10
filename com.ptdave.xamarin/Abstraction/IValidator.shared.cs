using System;
using System.Collections.Generic;
using System.Text;

namespace com.ptdave.xamarin.Abstraction
{
    public interface IValidator
    {
        bool IsValid { get; set; }
        bool IsNotValid { get; set; }
        string ErrorMessage { get; set; }
        event EventHandler IsValidChanged;
    }
}
