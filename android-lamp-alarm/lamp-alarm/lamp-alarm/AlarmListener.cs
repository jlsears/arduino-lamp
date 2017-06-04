using System.Text;
using System;
using Android.Content;
using Android.Widget;

namespace Core
{
    public class MorningAlarmListener : BroadcastReceiver
    {
        public MorningAlarmListener(){
        }

        public override void OnReceive(Context context, Intent intent)
        {
            Console.WriteLine("*****Hitting the OnReceive step in AlarmListener.cs*****");

        }
    }
}