/*Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.*/

using System;

namespace Problem12NthBit
{
    class NthBit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine((number & 1 << n) >> n);
        }
    }
}