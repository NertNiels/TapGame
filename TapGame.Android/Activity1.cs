using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using TapGame;

namespace TapGame.Android
{
    [Activity(Label = "TapGame.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.Sensor
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize | ConfigChanges.ScreenLayout)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = new Main();
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();



            View vw = (View)g.Services.GetService(typeof(View));
            vw.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.HideNavigation | (StatusBarVisibility)SystemUiFlags.ImmersiveSticky;
            vw.SetOnSystemUiVisibilityChangeListener(new MyUiVisibilityChangeListener(vw));
        }

        private class MyUiVisibilityChangeListener : Java.Lang.Object, View.IOnSystemUiVisibilityChangeListener
        {
            View targetView;
            public MyUiVisibilityChangeListener(View v)
            {
                targetView = v;
            }
            public void OnSystemUiVisibilityChange(StatusBarVisibility v)
            {
                if (targetView.SystemUiVisibility != ((StatusBarVisibility)SystemUiFlags.HideNavigation | (StatusBarVisibility)SystemUiFlags.Immersive))
                {
                    targetView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.HideNavigation | (StatusBarVisibility)SystemUiFlags.ImmersiveSticky;
                }
            }
        }
        
    }
}

