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
            Console.WriteLine("%%%%%Hitting the OnReceive step in AlarmList.cs%%%%%");
            // Toast.MakeText(context, "Picked up on my alarm event which will eventually lead to automated lamp light!", ToastLength.Long).Show();
        }
    }
}