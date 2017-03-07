/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;

namespace Problem04_MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            if (a == 0.0m || b == 0.0m || c == 0.0m)
            {
                Console.WriteLine("0");
            }
            else
            {
                if((a > 0.0m && b > 0.0m && c > 0.0m) || (a > 0.0m && b < 0.0m && c < 0.0m) || (a < 0.0m && b > 0.0m && c < 0.0m) || (a < 0.0m && b < 0.0m && c > 0.0m))
                {
                    Console.WriteLine("+");
                }

                if ((a < 0.0m && b < 0.0m && c < 0.0m) || (a < 0.0m && b > 0.0m && c > 0.0m) || (a > 0.0m && b < 0.0m && c > 0.0m) || (a > 0.0m && b > 0.0m && c < 0.0m))
                {
             
                    Console.WriteLine("-");
                }
            }
        }
    }
}