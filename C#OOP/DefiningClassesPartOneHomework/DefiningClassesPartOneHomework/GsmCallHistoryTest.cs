using System;

namespace DefiningClassesPartOneHomework
{
    class GsmCallHistoryTest
    {
        public void DisplayCallGsm()
        {
            Gsm gsm = new Gsm("Galaxy S7 edge", "Samsung", 799.99m, "Vali Koleva", new Battery("S-25", 21, 58, BatteryType.LiIon), new Display(5.6, 25));

            gsm.AddCall(new Call(DateTime.Now, "081255555", 253));
            gsm.AddCall(new Call(DateTime.Now, "457122", 12));
            gsm.AddCall(new Call(DateTime.Now, "78116", 10));
            Console.WriteLine(gsm.ToString());
            Console.WriteLine("Total price {0:f2} lv.", gsm.CalculatePrice(0.37m));
            Console.WriteLine("-----------------------------------------------");
         
            int maxDur = int.MinValue;
            int index = 0;
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {               
                if (gsm.CallHistory[i].Duration > maxDur)
                {
                    maxDur = gsm.CallHistory[i].Duration;
                    index = i;
                }
            }
           
            gsm.DeleteCall(gsm.CallHistory[index]);
            Console.WriteLine(gsm.ToString());
            Console.WriteLine("Total price {0:f2} lv.", gsm.CalculatePrice(0.37m));
            Console.WriteLine("---------------------------------------------------");
         
            gsm.ClearCallHistory();
            Console.WriteLine(gsm.ToString());
        }
    }
}