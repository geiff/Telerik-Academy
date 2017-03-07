/*Write a program first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. 
 Print the resulting integer on the console.*/
using System;

namespace Problem15BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                uint maskOne = (number & ((uint)1 << (p + i))) >> (p + i);
                uint maskTwo = (number & ((uint)1 << (q + i))) >> (q + i);

                if (maskOne == 1)
                {
                    number = (maskOne << q + i) | number;
                }
                else
                {
                    number = (~((uint) 1 << q + i)) & number;
                }

                if (maskTwo == 1)
                {
                    number = (maskTwo << p + i) | number;
                }
                else
                {
                    number = (~((uint) 1 << p + i)) & number;
                }
            }

            Console.WriteLine(number);
        }
    }
}