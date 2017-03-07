/*Write a program that finds the most frequent number in an array of N elements.*/
using System;

namespace Problem09FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];           
            int maxCount = 0;
            int elementMaxCount = -1;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && numbers[j] != -1)
                    {
                        count++;
                        numbers[j] = -1;
                    }
                }

                if (count >= maxCount)
                {
                    maxCount = count;
                    elementMaxCount = numbers[i];
                }
            }

            Console.WriteLine("{0} ({1} times)", elementMaxCount, maxCount);
        }
    }
}