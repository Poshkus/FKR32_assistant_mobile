using Xamarin.UITest;

namespace FKR32_assistant_mobile_UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            return ConfigureApp
                .iOS
                .DeviceIdentifier("2FE9E20D-4B13-49BA-9F34-63C1ED7B9808")
                .InstalledApp("com.companyname.FKR32_assistant_mobile")
                .EnableLocalScreenshots()
                .StartApp();
        }
    }
}