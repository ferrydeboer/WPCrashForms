using System.Reflection;
using System.Resources;
using WPCrashForms.Resources;

namespace WPCrashForms.Services
{
    public class ResourceTextProvider : ITextProvider
    {
        public const string ResourceId = "WPCrashForms.Resources.AppResources";

        private readonly ILocalize _localize;
        private readonly ResourceManager _resmgr;

        public ResourceTextProvider(ILocalize localize)
        {
            _localize = localize;
            _resmgr = new ResourceManager(
                ResourceId,
                typeof(AppResources).GetTypeInfo().Assembly);
        }

        public string GetText(string key)
        {
            var cultureInfo = _localize.GetLocale();
            var translation = _resmgr.GetString(key, cultureInfo);
            return translation;
        }
    }
}