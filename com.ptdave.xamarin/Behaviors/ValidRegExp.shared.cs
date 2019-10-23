using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace com.ptdave.xamarin.Behaviors
{
    public class ValidRegExp : Behavior<View>
    {
        /// <summary>
        /// Attach
        /// </summary>
        /// <param name="bindable"></param>
        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);

            if (bindable is Entry)
            {
                var entry = bindable as Entry;
                entry.TextChanged += Value_TextChanged;
            }
            else if (bindable is Editor)
            {
                var editor = bindable as Editor;
                editor.TextChanged += Value_TextChanged;
            }
        }

        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {
            var regexp = new Regex(this.RegExp);
            IsValid = regexp.IsMatch(e.NewTextValue);
        }

        /// <summary>
        /// Deatch
        /// </summary>
        /// <param name="bindable"></param>
        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
            if (bindable is Entry)
            {
                var entry = bindable as Entry;
                entry.TextChanged -= Value_TextChanged;
            }
            else if (bindable is Editor)
            {
                var editor = bindable as Editor;
                editor.TextChanged -= Value_TextChanged;
            }
        }


        public string RegExp
        {
            get => (string)GetValue(RegExpProperty);
            set => SetValue(RegExpProperty, value);
        }
        public readonly BindableProperty RegExpProperty = BindableProperty.Create(
            nameof(RegExp),
            typeof(string),
            typeof(ValidRegExp),
            BindingMode.TwoWay
            );


        /// <summary>
        /// Is the MinimumLength met
        /// </summary>
        public bool IsValid
        {
            get
            {
                return (bool)GetValue(IsValidProperty);
            }
            set
            {
                SetValue(IsValidProperty, value);
            }
        }

        public string ErrorMessage
        {
            get => GetValue(ErrorMessageProperty) as string;
            set => SetValue(ErrorMessageProperty, value);
        }
        public bool IsNotValid { get => !IsValid; }

        public static BindableProperty ErrorMessageProperty = BindableProperty.Create(
            nameof(ErrorMessage),
            typeof(string),
            typeof(MinimumLength),
            defaultValue: "Invalid value",
            defaultBindingMode: BindingMode.OneWayToSource);

        /// <summary>
        /// IsValidProperty
        /// </summary>
        public static BindableProperty IsValidProperty = BindableProperty.Create(
            nameof(IsValid),
            typeof(bool),
            typeof(MinimumLength),
            false);

        public event EventHandler IsValidChanged;
    }
}
