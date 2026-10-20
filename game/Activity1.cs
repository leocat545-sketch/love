using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Xna.Framework;
namespace AndroidHost {
  [Activity(Label = "Mon Jeu", MainLauncher = true, AlwaysRetainTaskState = true, LaunchMode = LaunchMode.SingleInstance, ScreenOrientation = ScreenOrientation.SensorLandscape, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
  public class Activity1 : AndroidGameActivity {
    protected override void OnCreate(Bundle b) {
      base.OnCreate(b);
      var g = new global::Demo.Game1();
      SetContentView((View)g.Services.GetService(typeof(View)));
      g.Run();
    }
  }
}
