/*Write a program that finds the length of the maximal increasing sequence in an array of N integers.*/
using System;

namespace Problem05MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int count = 1;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] < numbers[i])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;                       
                    }

                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }

            Console.WriteLine(maxCount);
        }
    }
}