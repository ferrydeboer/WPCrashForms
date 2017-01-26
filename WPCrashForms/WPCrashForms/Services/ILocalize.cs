using System.Globalization;

namespace WPCrashForms.Services
{
    public interface ILocalize
    {
        bool IsDutch { get; }

        CultureInfo GetDeviceCultureInfo();

        void SetLocale(CultureInfo ci);

        CultureInfo GetLocale();
    }
}