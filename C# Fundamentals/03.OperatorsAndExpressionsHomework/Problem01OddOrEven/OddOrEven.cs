/*Write a program that reads an integer from the console, uses an expression to check if given integer
  is odd or even, and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.*/
using System;

namespace Problem01OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even {0}", num);  
            }
            else
            {
                Console.WriteLine("odd {0}", num);
            }
        }
    }
}