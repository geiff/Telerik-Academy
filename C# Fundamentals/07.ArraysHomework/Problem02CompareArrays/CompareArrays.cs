/*Write a program that reads two integer arrays of size N from the console and compares them element by element.*/
using System;

namespace Problem02CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayOne[i] = number;
            }

            for (int i = n; i < n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayTwo[i - n] = number;
            }

            for (int i = 0; i < n; i++)
            {               
                    if (arrayOne[i] != arrayTwo[i])
                    {
                        isEqual = false;
                        break;
                    }            
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            
        }
    }
}