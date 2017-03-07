/*Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if given N is prime 
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive*/
using System;

namespace Problem08PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int index = 2;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                while (index < number)
                {
                    if (number%index == 0)
                    {
                        isPrime = false;
                        index = number;
                    }

                    index++;
                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}