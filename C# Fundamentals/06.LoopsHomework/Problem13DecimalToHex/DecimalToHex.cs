/*Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;

namespace Problem13DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string result = "";

            if (n == 0)
            {
                result += 0;
            }
            else
            {
                while (n >= 1)
                {
                    if (n % 16 > 9)
                    {
                        switch (n % 16)
                        {
                            case 10:
                                result += 'A';
                                break;
                            case 11:
                                result += 'B';
                                break;
                            case 12:
                                result += 'C';
                                break;
                            case 13:
                                result += 'D';
                                break;
                            case 14:
                                result += 'E';
                                break;
                            case 15:
                                result += 'F';
                                break;
                        }
                    }
                    else
                    {
                        result += n % 16;
                    }
                    
                    n = n / 16;
                }             
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}