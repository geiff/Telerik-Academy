/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm:
Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/
using System;

namespace Problem07SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        number[i] = number[i] ^ number[j];
                        number[j] = number[j] ^ number[i];
                        number[i] = number[i] ^ number[j];
                    }
                }
            }
           
            //Array.Sort(number);

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}