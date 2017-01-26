using System.Globalization;
using WPCrashForms.Services;

namespace WPCrashForms.WinPhone.Services
{
    public class WinLocalize : LocalizeBase
    {
        static CultureInfo _currentCulture;

        public override CultureInfo GetDeviceCultureInfo()
        {
            var name = Windows.System.UserProfile.GlobalizationPreferences.Languages[0];
            CultureInfo ci = new CultureInfo(name);
            return ci;
//              return null;
//            return CultureInfo.CurrentUICulture;
        }

        public override void SetLocale(CultureInfo ci)
        {
            _currentCulture = ci;
            CultureInfo.DefaultThreadCurrentCulture = _currentCulture;
            CultureInfo.DefaultThreadCurrentUICulture = _currentCulture;
        }

        public override CultureInfo GetLocale()
        {
            return _currentCulture;
        }
    }
}
