/*Write a program that finds the biggest of three numbers that are read from the console.*/
using System;

namespace Problem05BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float minNumber = float.MinValue;

            if (a > minNumber)
            {
                minNumber = a;
            }

            if (b > minNumber)
            {
                minNumber = b;
            }

            if (c > minNumber)
            {
                minNumber = c;
            }

            Console.WriteLine(minNumber);
        }
    }
}