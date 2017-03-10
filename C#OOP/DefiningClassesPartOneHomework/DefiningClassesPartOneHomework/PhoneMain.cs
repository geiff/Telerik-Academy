using System;

namespace DefiningClassesPartOneHomework
{
    class PhoneMain
    {
        static void Main()
        {
            GsmTest gsmTest = new GsmTest();
            GsmCallHistoryTest gsmTestWithCall = new GsmCallHistoryTest();
            gsmTest.Display();
            Console.WriteLine("------------------------------------------");
            gsmTestWithCall.DisplayCallGsm();
        }
    }
}