using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.ValueConverters
{
    public class Invert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            if (value is bool)
            {
                return !(bool)value;
            }

            throw new ArgumentException("value must be a boolean value");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return true;
            if (value is bool)
            {
                return !(bool)value;
            }

            throw new ArgumentException("value must be a boolean value");
        }
    }
}
