/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©*/

using System;
using System.Text;

namespace Problem08IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char a = '\u00A9';
            Console.WriteLine(" " + " " + " " + a);
            Console.WriteLine();
            Console.WriteLine(" " + " " + a + " " + a);
            Console.WriteLine();
            Console.WriteLine(" " + a + " " + " " + " " + a);
            Console.WriteLine();
            Console.WriteLine(a + " " + a + " " + a + " " + a);
        }
    }
}