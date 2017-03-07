/*Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.*/
using System;

namespace Problem01AllocateАrray
{
    class AllocateАrray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}