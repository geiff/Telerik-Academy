/*Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;

namespace Problem12DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            if (n == 0)
            {
                result += 0;
            }
            else
            {
                while (n != 1)
                {
                    result += n%2;
                    n = n/2;
                }

                result += 1;
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}