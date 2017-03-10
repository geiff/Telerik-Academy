using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    class ExtensionMethodMain
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Test for string builder");
            Console.WriteLine(builder.Substring(2, 5));

            List<int> num = new List<int>() {1, 5, 8, 3};
            List<double> numD = new List<double>() { 0.01, 5.2, 0.008, 3.5 };
            Console.WriteLine("Integer numbers" + "\n" + num.SumNum() + "\n" + num.ProductNum() + "\n" + num.MinNum() + "\n" + num.MaxNum() + "\n" + num.AverageNum());
            Console.WriteLine("Double numbers" + "\n" + numD.SumNum() + "\n" + numD.ProductNum() + "\n" + numD.MinNum() + "\n" + numD.MaxNum() + "\n" + numD.AverageNum());

        }
    }
}