using Android.App;
using Android.Widget;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.OS;

namespace Food_Fetish
{
    [Activity(Label = "Food_Fetish", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            int clicks = 0;

            //Get the ID's from the layout
            Button settingsButton = FindViewById<Button>(Resource.Id.settingsBtn);
            Button helloButton = FindViewById<Button>(Resource.Id.button2);
            settingsButton.Click += delegate
            {
                SetContentView(Resource.Layout.Settings);
            };
            helloButton.Click += delegate
            {
                clicks++;
                string clicksString = clicks.ToString();
                helloButton.Text = $"You clicked me :{clicksString})";
            };
        }
    }
}

