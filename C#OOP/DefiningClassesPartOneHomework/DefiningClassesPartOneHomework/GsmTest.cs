using System;

namespace DefiningClassesPartOneHomework
{
    public class GsmTest
    {
        public void Display()
        {
            Gsm[] gsms = new Gsm[]
            {
                new Gsm("Xperia XZ", "Sony", 1099.99m, "Stoyan Kolev", new Battery("HG-25", 25, 53, BatteryType.LiIon),new Display(5.2, 14)),
                new Gsm("K6","Lenovo", 119.00m, "Nino Sashev", new Battery("ML-K", 48, 53, BatteryType.NiCd), new Display(4.5, 21)),
                new Gsm("Galaxy S7","Samsung", 719.00m, "Sergej Vil", new Battery("LJ-12", 20, 32, BatteryType.NiMH), new Display(5, 10)),
                new Gsm("P9 Lite", "Huawei")
            };

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }

            Console.WriteLine(Gsm.IPhoneFourS);
        }
    }
}