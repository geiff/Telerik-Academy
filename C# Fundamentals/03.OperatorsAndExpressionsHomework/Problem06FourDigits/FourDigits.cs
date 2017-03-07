/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.*/

using System;
using System.Text;

namespace Problem06FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int sum = 0;
            StringBuilder reversNumber = new StringBuilder();
            StringBuilder lastDigit = new StringBuilder();
            StringBuilder secondExchangesThird = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sum += int.Parse(input[i].ToString());
                reversNumber.Append(input[i]);
            }

            lastDigit.Append(input[input.Length - 1]);
            for (int i = 0; i < input.Length - 1; i++)
            {
                lastDigit.Append(input[i]);
            }

            secondExchangesThird.Append(input[0]);
            secondExchangesThird.Append(input[2]);
            secondExchangesThird.Append(input[1]);
            secondExchangesThird.Append(input[3]);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", sum, reversNumber, lastDigit, secondExchangesThird);
        }
    }
}