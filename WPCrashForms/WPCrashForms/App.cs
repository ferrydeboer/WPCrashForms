using WPCrashForms.Resources;
using WPCrashForms.Services;
using Xamarin.Forms;

namespace WPCrashForms
{
    public class App : Application
    {
        public App()
        {
            var ci = Localization.GetDeviceCultureInfo();
            AppResources.Culture = ci;
            Localization.SetLocale(ci);

            var tp = new ResourceTextProvider(Localization);
            // The root page of your application
            var content = new ContentPage
            {
                Title = "WPCrashForms",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = tp.GetText("HelloWorld")
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        public static ILocalize Localization { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}