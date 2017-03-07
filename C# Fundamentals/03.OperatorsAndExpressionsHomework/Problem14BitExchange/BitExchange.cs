/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).*/
using System;

namespace Problem14BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint maskThree = (number & (1 << 3)) >> 3;
            uint maskTwentyFour = (number & (1 << 24)) >> 24;
            uint maskFour = (number & (1 << 4)) >> 4;
            uint maskTwentyFive = (number & (1 << 25)) >> 25;
            uint maskFive = (number & (1 << 5)) >> 5;
            uint maskTwentySix = (number & (1 << 26)) >> 26;

            if (maskThree == 1)
            {
                number = (maskThree << 24) | number;
            }
            else
            {
                number = (~((uint)1 << 24)) & number;
            }

            if (maskTwentyFour == 1)
            {
                number = (maskTwentyFour << 3) | number;
            }
            else
            {
                number = (~((uint)1 << 3)) & number;
            }

            if (maskFour == 1)
            {
                number = (maskFour << 25) | number;
            }
            else
            {
                number = (~((uint)1 << 25)) & number;
            }

            if (maskTwentyFive == 1)
            {
                number = (maskTwentyFive << 4) | number;
            }
            else
            {
                number = (~((uint)1 << 4)) & number;
            }

            if (maskFive == 1)
            {
                number = (maskFive << 26) | number;
            }
            else
            {
                number = (~((uint)1 << 26)) & number;
            }

            if (maskTwentySix == 1)
            {
                number = (maskTwentySix << 5) | number;
            }
            else
            {
                number = (~((uint)1 << 5)) & number;
            }

              Console.WriteLine(number);
        }
    }
}