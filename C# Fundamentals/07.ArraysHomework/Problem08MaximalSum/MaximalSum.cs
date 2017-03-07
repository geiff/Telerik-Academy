/*Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
Can you do it with only one loop (with single scan through the elements of the array)?*/

using System;

namespace Problem08MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());           
            long sum = 0;
            long maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());                   //Kadane’s algorithm
                if (maxSum < sum)
                {
                    maxSum = sum;                     
                }                                         
                else if (sum < 0)
                {
                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}