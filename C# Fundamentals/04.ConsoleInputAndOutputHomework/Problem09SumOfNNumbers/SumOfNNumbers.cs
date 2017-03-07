/*Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.*/

using System;

namespace Problem09SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input != "")
                {
                    double num = double.Parse(input);
                    sum += num;
                }
                else
                {
                    double num = 0;
                    sum += num;
                }               
            }

            Console.WriteLine(sum);
        }
    }
}