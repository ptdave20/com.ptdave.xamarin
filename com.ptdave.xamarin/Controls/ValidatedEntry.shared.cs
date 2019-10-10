using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace com.ptdave.xamarin.Controls
{
    public class ValidatedEntry : Entry, IValidated
    {
        public ValidatedEntry()
        {
            this.BindingContextChanged += ValidatedEntry_BindingContextChanged;
        }

        private void ValidatedEntry_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        public bool IsValid
        {
            get => (bool)GetValue(IsValidProperty);
            set => SetValue(IsValidProperty, value);
        }

        public bool IsNotValid
        {
            get => (bool)GetValue(IsNotValidProperty);
            set => SetValue(IsNotValidProperty, value);
        }
        public string ErrorMessage {
            get
            {
                return Behaviors.Where(x => x is IValidator).Select(x => x as IValidator).Where(x => x.IsNotValid).Select(x => x.ErrorMessage).FirstOrDefault() ?? string.Empty;
            }
        }

        public static readonly BindableProperty IsValidProperty = BindableProperty.Create("IsValid", typeof(bool), typeof(ValidatedEntry), false, BindingMode.OneWayToSource);
        public static readonly BindableProperty IsNotValidProperty = BindableProperty.Create("IsNotValid", typeof(bool), typeof(ValidatedEntry), false, BindingMode.OneWayToSource);
        public static readonly BindableProperty ErrorMessageProperty = BindableProperty.Create("ErrorMessage", typeof(string), typeof(ValidatedEntry), "", BindingMode.OneWayToSource);

        public event EventHandler ValidChanged;

        public void Connect(IValidator validator)
        {
            validator.IsValidChanged += Validator_IsValidChanged;
        }

        private void Validator_IsValidChanged(object sender, EventArgs e)
        {
            var valid = !Behaviors.Where(x => x is IValidator).Select(x => x as IValidator).Where(x => x.IsNotValid).Any();
            if(valid != IsValid)
            {
                IsValid = valid;
                IsNotValid = !valid;
                ValidChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Disconnect(IValidator validator)
        {
            validator.IsValidChanged -= Validator_IsValidChanged;
        }
       
    }
}