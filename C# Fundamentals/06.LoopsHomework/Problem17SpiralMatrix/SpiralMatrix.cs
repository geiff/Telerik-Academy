/*Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) 
 and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.*/

using System;

namespace Problem17SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            int number = 1;
            
            int countNumber = 0;
            int indexRowTop = 0;
            int indexColRight = n - 1;
            int indexRowBottom = n - 1;
            int indexColLeft = 0;

            while (countNumber <= n*n)
            {  
                for (int col = 0; col < n; col++)
                {
                    if (matrix[indexRowTop, col] == 0)
                    {
                        matrix[indexRowTop, col] = number;
                        number++;
                        countNumber = number;
                    }                  
                }
                indexRowTop++;

                for (int row = 0; row < n; row++)
                {
                    if (matrix[row, indexColRight] == 0)
                    {
                        matrix[row, indexColRight] = number;
                        number++;
                        countNumber = number;
                    }
                    
                }
                indexColRight--;

                for (int col = n - 1; col >= 0; col--)
                {
                    if (matrix[indexRowBottom, col] == 0)
                    {
                        matrix[indexRowBottom, col] = number;
                        number++;
                        countNumber = number;
                    }
                   
                }
                indexRowBottom--;

                for (int row = n - 1; row >= 0; row--)
                {
                    if (matrix[row, indexColLeft] == 0)
                    {
                        matrix[row, indexColLeft] = number;
                        number++;
                        countNumber = number;
                    }
                    
                }
                indexColLeft++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}