using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace com.ptdave.xamarin.Helpers
{
    public static class Extensions
    {
        public static string GetDisplayName(this object value)
        {
            Type genObjectType = value.GetType();
            MemberInfo[] memberInfo = genObjectType.GetMember(genObjectType.ToString());
            if((memberInfo != null && memberInfo.Length > 0))
            {
                var _attrib = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DisplayNameAttribute), false);
                if(_attrib != null && _attrib.Length > 0) {
                    return ((System.ComponentModel.DisplayNameAttribute)_attrib.ElementAt(0)).DisplayName;
                }
            }
            return value.ToString();
        }
        public static string GetDescription(this object value)
        {
            Type genObjectType = value.GetType();
            MemberInfo[] memberInfo = genObjectType.GetMember(genObjectType.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _attrib = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (_attrib != null && _attrib.Length > 0) {
                    return ((System.ComponentModel.DescriptionAttribute)_attrib.ElementAt(0)).Description;
                }
            }
            return value.ToString();
        }
    }
}
