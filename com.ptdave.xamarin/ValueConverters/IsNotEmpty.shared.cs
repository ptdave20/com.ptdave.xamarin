using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.ValueConverters
{
    public class IsNotEmpty : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            if (value is string)
            {
                return !string.IsNullOrEmpty((string)value);
            }
            else if (value is IEnumerable)
            {
                return ((IEnumerable)value).Cast<object>().Any();
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
