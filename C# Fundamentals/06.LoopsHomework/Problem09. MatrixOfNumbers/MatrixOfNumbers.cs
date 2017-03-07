/*Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.
Challenge: achieve the same effect without nested loops*/

using System;

namespace Problem09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row, col] = row + 1 + col);                  
                }

                Console.WriteLine();
            }
        }
    }
}