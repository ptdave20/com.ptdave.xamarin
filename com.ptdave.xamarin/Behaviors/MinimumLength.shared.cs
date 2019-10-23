using com.ptdave.xamarin.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.Behaviors
{
    /// <summary>
    /// Minimum Length Behavior
    /// </summary>
    public class MinimumLength : Behavior<View>
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
            } else if(bindable is Editor)
            {
                var editor = bindable as Editor;
                editor.TextChanged += Value_TextChanged;
            }
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

        /// <summary>
        /// Minimum Length to be met
        /// </summary>
        public int Length
        {
            get
            {
                return (int)GetValue(MinimumLengthProperty);
            }
            set
            {
                SetValue(MinimumLengthProperty, value);
            }
        }


        /// <summary>
        /// MinimumLengthProperty
        /// </summary>
        public static readonly BindableProperty MinimumLengthProperty = BindableProperty.Create(
            nameof(Length), 
            typeof(int), 
            typeof(MinimumLength), 
            -1);

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
            defaultValue: "Minimum length not met",
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

        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Length > -1)
            {
                IsValid = e.NewTextValue.Length >= Length;
            } else
            {
                // We need a minimum length greater -1
                IsValid = true;
            }
        }
    }
}
