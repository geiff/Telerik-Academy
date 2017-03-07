/*The gravitational field of the Moon is approximately 17% of that on the Earth.

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
The weight W should be read from the console.*/

using System;

namespace Problem02MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float num = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:F3}", num * 17 / 100);
        }
    }
}