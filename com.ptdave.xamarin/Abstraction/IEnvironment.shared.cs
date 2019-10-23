using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Reference: https://codetraveler.io/2019/09/11/check-for-dark-mode-in-xamarin-forms/

namespace com.ptdave.xamarin.Abstraction
{
    public interface IEnvironment
    {
        Task<Theme> GetOperatingSystemThemeAsync();
    }

    public enum Theme { Light, Dark, Unknown };
}
