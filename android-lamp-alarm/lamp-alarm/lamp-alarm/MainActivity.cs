using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Core;

namespace lamp_alarm
{
    [Activity(Label = "lamp_alarm", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        // int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ToggleButton activatebutton = FindViewById<ToggleButton>(Resource.Id.activateButton);

            activatebutton.Click += (o, e) =>
            {
                // Perform action on clicks
                if (activatebutton.Checked)
                    Toast.MakeText(this, "On", ToastLength.Short).Show();

                else
                    Toast.MakeText(this, "Off", ToastLength.Short).Show();
            };

            while (activatebutton.Checked)
            {
                var make_light = new MorningAlarmListener();

                var noise_filter = new IntentFilter("com.android.deskclock.ALARM_ALERT");

                RegisterReceiver(make_light, noise_filter);
            }
        }
    }
}

