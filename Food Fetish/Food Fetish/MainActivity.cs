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
        // Set the instances
        Button MenuButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Remove the default title
            RequestWindowFeature(WindowFeatures.NoTitle);

            // Lock the app in portrait mode
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;

            // Start the app
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Assign ID's
            MenuButton = FindViewById<Button>(Resource.Id.MenuButton);


        }
    }
}

