﻿/*Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.*/
using System;

namespace Problem08NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}