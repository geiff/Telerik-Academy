/*Write a program that, depending on the first line of the input, reads an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;

namespace Problem09IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "integer":
                    Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                    break;
                case "real":
                    Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) + 1);
                    break;
                case "text":
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
            }
        }
    }
}