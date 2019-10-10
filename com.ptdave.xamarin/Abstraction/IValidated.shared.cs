using System;
using System.Collections.Generic;
using System.Text;

namespace com.ptdave.xamarin.Abstraction
{
    public interface IValidated
    {
        bool IsValid { get; set; }
        bool IsNotValid { get; set; }
        string ErrorMessage { get; }

        event EventHandler ValidChanged;

        void Connect(IValidator validator);
        void Disconnect(IValidator validator);

    }
}
