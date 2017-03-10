using System;

namespace Delegate
{
    public delegate void TimeDelegate();

    public class TimerMain
    {
        public static void Timer()
        {
            Console.WriteLine("Timer");
        }

        public static void TimerOne()
        {
            Console.WriteLine("Timer1");
        }

        public static void Main()
        {
            TimeDelegate timeDelegate = new TimeDelegate(Timer);

            for (int i = 0; i < 2; i++)
            {
                timeDelegate();
                timeDelegate += TimerOne;
                timeDelegate -= Timer;
            }
        }
    }
}