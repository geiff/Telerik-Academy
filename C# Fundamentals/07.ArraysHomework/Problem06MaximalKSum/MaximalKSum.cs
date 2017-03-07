/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.*/
using System;

namespace Problem06MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            long sum = 0;

            Array.Sort(number);

            for (int i = number.Length - k; i < number.Length; i++)
            {
                sum += number[i];
            }     

            Console.WriteLine(sum);
        }
    }
}