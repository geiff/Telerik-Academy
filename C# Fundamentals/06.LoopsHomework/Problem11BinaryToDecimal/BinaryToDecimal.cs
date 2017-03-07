/*Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

namespace Problem11BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long numDec = new long();
            int stepen = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {                
                if (binary[i] == '1')
                {
                    numDec += (long)Math.Pow(2, stepen);
                }
                
                stepen++;
            }

            Console.WriteLine(numDec);
        }
    }
}