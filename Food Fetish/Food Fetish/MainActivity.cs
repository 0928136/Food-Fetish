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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Get the ID's from the layout
            Button settingsButton = FindViewById<Button>(Resource.Id.settingsBtn);
            settingsButton.Click += delegate
            {
                SetContentView(Resource.Layout.Settings);
            };
        }
    }
}

