using System.Text;
using System;
using Android.Content;
using Android.Widget;

namespace Core
{
    public class MorningAlarmListener : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Pickuped on my alarm event which will eventually lead to automated lamp light!" + i.GetStringExtra("key"), ToastLength.Long).Show();
        }
    }
}