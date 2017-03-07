/*Write a program that sorts an array of integers using the Quick sort algorithm.*/
using System;

namespace Problem14QuickSort
{
    class QuickSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < numers.Length; j++)
            {
                int pivot = j;
                int storeIndex = pivot + 1;

                for (int i = pivot + 1; i < numers.Length; i++)
                {

                    if (numers[i] < numers[pivot])
                    {
                        int c1 = numers[i];
                        numers[i] = numers[storeIndex];
                        numers[storeIndex] = c1;

                        storeIndex++;

                        int c = numers[pivot];
                        numers[pivot] = numers[storeIndex - 1];
                        numers[storeIndex - 1] = c;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numers[i]);
            }
        }
    }
}