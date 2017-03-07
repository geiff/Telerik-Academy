/*Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.*/
using System;

namespace Problem06BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

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

            if (d > minNumber)
            {
                minNumber = d;
            }

            if (e > minNumber)
            {
                minNumber = e;
            }

            Console.WriteLine(minNumber);
        }
    }
}