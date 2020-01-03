using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.Behaviors
{
    public class HadFocus : Behavior<View>
    {
        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Focused += Bindable_Focused;
        }

        private void Bindable_Focused(object sender, FocusEventArgs e)
        {
            HasHadFocus = true;
        }

        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.Focused -= Bindable_Focused;
        }

        public bool HasHadFocus {
            get => (bool)GetValue(HasHadFocusProperty);
            set => SetValue(HasHadFocusProperty, value);
        }

        public readonly BindableProperty HasHadFocusProperty = BindableProperty.Create(
            nameof(HasHadFocus),
            typeof(bool),
            typeof(HadFocus),
            false,
            BindingMode.OneWay);
    }
}
