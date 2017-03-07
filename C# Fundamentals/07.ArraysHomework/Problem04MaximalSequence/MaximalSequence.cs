﻿/*Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.*/
using System;

namespace Problem04MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int count = 1;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
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