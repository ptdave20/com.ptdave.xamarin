using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.ValueConverters
{
    public class GreaterThan : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null || parameter == null)
            {
                return false;
            }
            if(value is int)
            {
                return (int)value > (int)parameter;
            }
            else if (value is uint)
            {
                return (uint)value > (uint)parameter;
            }
            else if (value is short)
            {
                return (short)value > (short)parameter;
            }
            else if (value is byte)
            {
                return (byte)value > (byte)parameter;
            }
            else if(value is double)
            {
                return (double)value > (double)parameter;
            }
            else if (value is decimal)
            {
                return (decimal)value > (decimal)parameter;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
