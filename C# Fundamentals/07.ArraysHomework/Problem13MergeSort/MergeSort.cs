/*Write a program that sorts an array of integers using the Merge sort algorithm.*/
using System;

namespace Problem13MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            MergeRegurse(numbers, 0, numbers.Length - 1);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MergeRegurse(int[] numbers, int left, int right)
        {
            int mid; 
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeRegurse(numbers, left, mid);
                MergeRegurse(numbers, mid + 1, right);
                MergeSortResult(numbers, left, mid + 1, right);
            }     
        }

        public static int[] MergeSortResult(int[] numbers, int left, int mid, int right)
        {
            int[] result = new int[numbers.Length];
           
            int indexResult = left;
            int leftEnd = mid - 1;
            int num_elements = right - left + 1;
            while (left <= leftEnd && mid <= right)
            {
                if (numbers[left] <= numbers[mid])
                {
                   
                    result[indexResult++] = numbers[left++];
                }
                else
                {
                    
                    result[indexResult++] = numbers[mid++];
                }
            }

            while (left <= leftEnd)
            {
                result[indexResult++] = numbers[left++];
            }

            while (mid <= right)
            {
                result[indexResult++] = numbers[mid++];
            }

            for (int i = 0; i < num_elements; i++)
            {
                numbers[right] = result[right];
                right--;
            }
            return result;
        }
    }
}