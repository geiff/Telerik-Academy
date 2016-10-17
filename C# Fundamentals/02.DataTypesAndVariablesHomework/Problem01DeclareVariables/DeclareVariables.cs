/*Declare five variables choosing for each of them the most appropriate of the types 
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
 * 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/
using System;

namespace Problem01DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            byte a = 97;
            sbyte b = -115;
            short c = -10000;
            ushort d = 52130;
            int f = 4825932;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
        }
    }
}
