/*Create a program that assigns null values to an integer and to a double variable.

Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

namespace Problem12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();
            Console.WriteLine(a + 5);
            Console.WriteLine(b + 5.1);
            Console.WriteLine();
            Console.WriteLine(a + null);
            Console.WriteLine(b + null);
        }
    }
}