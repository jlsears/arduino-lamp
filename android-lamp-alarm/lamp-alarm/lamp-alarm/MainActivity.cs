using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Core;
using System.Threading;
using System.Threading.Tasks;

namespace lamp_alarm
{
    [Activity(Label = "lamp_alarm2", MainLauncher = true)]
    // , Icon = "@drawable/icon"
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ToggleButton activateButton = FindViewById<ToggleButton>(Resource.Id.activateButton);

            Console.WriteLine("***** Approaching button click *****");

            activateButton.Click += (o, e) =>
            {
                Console.WriteLine("***** Inside the button click! *****");
                // perform action on clicks
                if (activateButton.Checked)
                {
                    Console.WriteLine("***** Inside the if! *****");
                    Toast.MakeText(this, "on", ToastLength.Short).Show();
                    return;
                }

                else
                {
                    Console.WriteLine("***** Inside the else! *****");
                    Toast.MakeText(this, "off", ToastLength.Short).Show();
                }
            };

            // Listener for change in on/off button
            activateButton.CheckedChange += (s, e) =>
            {
                if (activateButton.Checked)
                {
                    Console.WriteLine("***** inside CheckedChange event! *****");

                    // Toast message that will briefly pop up verifying on state
                    Context activatedContext = ApplicationContext;
                    Toast.MakeText(activatedContext, "Picked up on my alarm event which will eventually lead to automated lamp light!", ToastLength.Long).Show();

                    // var make_light = new MorningAlarmListener();
                    MorningAlarmListener make_light = new MorningAlarmListener();

                    IntentFilter noise_filter = new IntentFilter("com.android.deskclock.ALARM_SERVICE");

                    RegisterReceiver(make_light, noise_filter);

                }
            };
        }
    }
}

