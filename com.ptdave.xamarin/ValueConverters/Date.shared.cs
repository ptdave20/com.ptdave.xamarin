using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace com.ptdave.xamarin.ValueConverters
{
    public class Date : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "";
            var format = (string)parameter;
            format = format.ToLower().Trim();

            switch(format)
            {
                case "short":
                    format = "M/d/yy, h:mm a";
                    break;
                case "medium":
                    format = "MMM d, y, h:mm:ss a";
                    break;
                case "long":
                    format = "MMMM d, y, h:mm:ss a z";
                    break;
                case "full":
                    format = "dddd, MMMM d, y, h:mm:ss a zzzz";
                    break;
                case "shortDate":
                    format = "d";
                    break;
                case "mediumDate":
                    format = "MMM d, y";
                    break;
                case "longDate":
                    format = "MMMM d, y";
                    break;
                case "fullDate":
                    format = "dddd, MMMM d, y";
                    break;
                case "shortTime":
                    format = "h:mm a";
                    break;
                case "mediumTime":
                    format = "h:mm:ss a";
                    break;
                case "longTime":
                    format = "h:mm:ss a z";
                    break;
                case "fullTime":
                    format = "h:mm:ss a zzzz";
                    break;

            }


            if(value is DateTime)
            {
                var date = (DateTime)value;
                return date.ToString(format);
            } else if(value is DateTimeOffset)
            {
                var date = (DateTime)value;
                return date.ToString(format);
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
