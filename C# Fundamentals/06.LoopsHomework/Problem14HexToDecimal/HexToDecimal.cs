/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

namespace Problem14HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            long numDec = new long();
            int stepen = 0;

            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                switch (hexNumber[i])
                {
                    case '0':
                        numDec += 0 * (long)Math.Pow(16, stepen);
                        break;
                    case '1':
                        numDec += 1 * (long)Math.Pow(16, stepen);
                        break;
                    case '2':
                        numDec += 2 * (long)Math.Pow(16, stepen);
                        break;
                    case '3':
                        numDec += 3 * (long)Math.Pow(16, stepen);
                        break;
                    case '4':
                        numDec += 4 * (long)Math.Pow(16, stepen);
                        break;
                    case '5':
                        numDec += 5 * (long)Math.Pow(16, stepen);
                        break;
                    case '6':
                        numDec += 6 * (long)Math.Pow(16, stepen);
                        break;
                    case '7':
                        numDec += 7 * (long)Math.Pow(16, stepen);
                        break;
                    case '8':
                        numDec += 8 * (long)Math.Pow(16, stepen);
                        break;
                    case '9':
                        numDec += 9 * (long)Math.Pow(16, stepen);
                        break;
                    case 'A':
                        numDec += 10 * (long)Math.Pow(16, stepen);
                        break;
                    case 'B':
                        numDec += 11 * (long)Math.Pow(16, stepen);
                        break;
                    case 'C':
                        numDec += 12 * (long)Math.Pow(16, stepen);
                        break;
                    case 'D':
                        numDec += 13 * (long)Math.Pow(16, stepen);
                        break;
                    case 'E':
                        numDec += 14 * (long)Math.Pow(16, stepen);
                        break;
                    case 'F':
                        numDec += 15 * (long)Math.Pow(16, stepen);
                        break;
                }

                stepen++;
            }

            Console.WriteLine(numDec);
        }
    }
}