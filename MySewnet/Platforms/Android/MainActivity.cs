using Android.App;
using Android.Content.PM;
using Android.Content;
using Android.OS;

namespace MySewnet
{
    [Activity(LaunchMode = LaunchMode.SingleTask,Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    [IntentFilter(new[] { Intent.ActionView }, Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataScheme = "sewnet", DataHost = "launch")]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
