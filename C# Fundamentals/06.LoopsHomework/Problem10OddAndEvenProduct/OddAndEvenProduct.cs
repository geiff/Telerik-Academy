/*You are given N integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to N, so the first element is odd, the second is even, etc.*/
using System;

namespace Problem10OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            long productOdd = 1;
            long productEven = 1;

            for (int i = 0; i < numbers.Length; i ++)
            {
                if ((i + 1)%2 == 0)
                {
                    productEven *= int.Parse(numbers[i]);
                }
                else
                {
                    productOdd *= int.Parse(numbers[i]);
                }
               
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes {0}", productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }
        }
    }
}