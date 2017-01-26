using System.Globalization;
using AcuteZorg.Core.Services.Localization;

namespace WPCrashForms.Services
{
    public abstract class LocalizeBase : ILocalize
    {
        public bool IsDutch => GetLocale().TwoLetterISOLanguageName == Languages.Dutch;

        public abstract CultureInfo GetDeviceCultureInfo();

        public abstract void SetLocale(CultureInfo ci);

//        {
//            CultureInfo.DefaultThreadCurrentCulture = ci;
//            CultureInfo.DefaultThreadCurrentUICulture = ci;
//        }

        public virtual CultureInfo GetLocale()
        {
            return CultureInfo.CurrentUICulture;
        }

/*        public CultureInfo GetDeviceCultureInfo()
        {
            var netLanguage = GetDotNetLanguage();

            if (_currentCultureInfo != null)
            {
                return _currentCultureInfo;
            }

            try
            {
                _currentCultureInfo = new CultureInfo(netLanguage);
            }
            catch (CultureNotFoundException)
            {
                // iOS locale not valid .NET culture (eg. "en-ES" : English in Spain)
                // fallback to first characters, in this case "en"
                try
                {
                    var fallback = ToDotnetFallbackLanguage(new PlatformCulture(netLanguage));
                    _currentCultureInfo = new CultureInfo(fallback);
                }
                catch (CultureNotFoundException)
                {
                    // iOS language not valid .NET culture, falling back to English
                    _currentCultureInfo = new CultureInfo("en");
                }
            }

            return _currentCultureInfo;
        }

        protected abstract string ToDotnetFallbackLanguage(PlatformCulture platformCulture);

        protected abstract string GetDotNetLanguage();*/
    }
}
