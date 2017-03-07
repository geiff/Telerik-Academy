/*Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.*/
using System;

namespace Problem11BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            int min = 0;
            int max = numbers.Length - 1;
            int middel = (min + max) / 2;
            bool isFind = false;

            while (max >= min)
            {
                middel = (min + max) / 2;
                if (numbers[middel] == x)
                {
                    Console.WriteLine(middel);    
                    isFind = true;
                    break;
                    
                }
                else
                {
                    if (x < numbers[middel])
                    {
                        max = middel - 1;
                    }
                    else
                    {
                        min = middel + 1;
                    }
                }
            }

            if (!isFind)
            {
                Console.WriteLine("-1");
            }
        }
    }
}