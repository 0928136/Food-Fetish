using Android.App;
using Android.Widget;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.OS;

namespace Food_Fetish
{
    [Activity(Label = "Food_Fetish", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button MenuButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Assign ID's
            MenuButton = FindViewById<Button>(Resource.Id.MenuButton);


        }
    }
}

