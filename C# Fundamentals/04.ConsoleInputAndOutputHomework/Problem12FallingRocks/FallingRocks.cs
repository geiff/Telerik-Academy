/*Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.*/

using System;

namespace Problem12FallingRocks
{
    class FallingRocks
    {
        static void Main()
        {
            int xStartPosition = 50;
            int yStartPosition = 60;
            int xStartStaysPosition = 20;
            int yStartStaysPosition = 40;
           
            char[] stays = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };

            Console.SetCursorPosition(xStartStaysPosition, yStartStaysPosition);
            Console.WriteLine(stays[0]);
            Console.SetCursorPosition(xStartStaysPosition + 10, yStartStaysPosition - 5);
            Console.WriteLine(stays[1]);
            Console.SetCursorPosition(xStartStaysPosition - 10, yStartStaysPosition - 7);
            Console.WriteLine(stays[2]);
            Console.SetCursorPosition(xStartStaysPosition + 25, yStartStaysPosition - 7);
            Console.WriteLine(stays[3]);
            Console.SetCursorPosition(xStartStaysPosition + 15, yStartStaysPosition - 3);
            Console.WriteLine(stays[4]);
            Console.SetCursorPosition(xStartStaysPosition + 40, yStartStaysPosition - 10);
            Console.WriteLine(stays[5]);
            Console.SetCursorPosition(xStartStaysPosition - 8, yStartStaysPosition);
            Console.WriteLine(stays[6]);
            Console.SetCursorPosition(xStartStaysPosition + 35, yStartStaysPosition - 3);
            Console.WriteLine(stays[7]);
            Console.SetCursorPosition(xStartStaysPosition + 26, yStartStaysPosition - 1);
            Console.WriteLine(stays[8]);
            Console.SetCursorPosition(xStartStaysPosition + 33, yStartStaysPosition - 7);
            Console.WriteLine(stays[9]);
            Console.SetCursorPosition(xStartStaysPosition + 50, yStartStaysPosition - 4);
            Console.WriteLine(stays[10]);
            Console.SetCursorPosition(xStartStaysPosition  + 60, yStartStaysPosition - 5);
            Console.WriteLine(stays[11]);

            Console.SetCursorPosition(xStartPosition, yStartPosition);           
            Console.WriteLine("(0)");

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.RightArrow)
                {
                    xStartPosition += 4;
                    yStartStaysPosition += 4;

                    if (yStartStaysPosition == yStartPosition)
                    {
                        yStartStaysPosition = 40;
                    }
                   
                    if (xStartPosition > 108)
                    {
                        xStartPosition -= 4;
                    }


                    Console.Clear();

                    Console.SetCursorPosition(xStartStaysPosition, yStartStaysPosition);
                    Console.WriteLine(stays[0]);
                    Console.SetCursorPosition(xStartStaysPosition + 10, yStartStaysPosition - 5);
                    Console.WriteLine(stays[1]);
                    Console.SetCursorPosition(xStartStaysPosition - 10, yStartStaysPosition - 7);
                    Console.WriteLine(stays[2]);
                    Console.SetCursorPosition(xStartStaysPosition + 25, yStartStaysPosition - 7);
                    Console.WriteLine(stays[3]);
                    Console.SetCursorPosition(xStartStaysPosition + 15, yStartStaysPosition - 3);
                    Console.WriteLine(stays[4]);
                    Console.SetCursorPosition(xStartStaysPosition + 40, yStartStaysPosition - 10);
                    Console.WriteLine(stays[5]);
                    Console.SetCursorPosition(xStartStaysPosition - 8, yStartStaysPosition);
                    Console.WriteLine(stays[6]);
                    Console.SetCursorPosition(xStartStaysPosition + 35, yStartStaysPosition - 3);
                    Console.WriteLine(stays[7]);
                    Console.SetCursorPosition(xStartStaysPosition + 26, yStartStaysPosition - 1);
                    Console.WriteLine(stays[8]);
                    Console.SetCursorPosition(xStartStaysPosition + 33, yStartStaysPosition - 7);
                    Console.WriteLine(stays[9]);
                    Console.SetCursorPosition(xStartStaysPosition + 50, yStartStaysPosition - 4);
                    Console.WriteLine(stays[10]);
                    Console.SetCursorPosition(xStartStaysPosition + 60, yStartStaysPosition - 5);
                    Console.WriteLine(stays[11]);

                    Console.SetCursorPosition(xStartPosition, yStartPosition);
                    Console.WriteLine("(0)");
                }

                if (input.Key == ConsoleKey.LeftArrow)
                {
                    xStartPosition -= 4;
                    yStartStaysPosition += 4;

                    if (yStartStaysPosition == yStartPosition)
                    {
                        yStartStaysPosition = 40;
                    }

                    if (xStartPosition < 0)
                    {
                        xStartPosition += 4;
                    }

                    Console.Clear();

                    Console.SetCursorPosition(xStartStaysPosition, yStartStaysPosition);
                    Console.WriteLine(stays[0]);
                    Console.SetCursorPosition(xStartStaysPosition + 10, yStartStaysPosition - 5);
                    Console.WriteLine(stays[1]);
                    Console.SetCursorPosition(xStartStaysPosition - 10, yStartStaysPosition - 7);
                    Console.WriteLine(stays[2]);
                    Console.SetCursorPosition(xStartStaysPosition + 25, yStartStaysPosition - 7);
                    Console.WriteLine(stays[3]);
                    Console.SetCursorPosition(xStartStaysPosition + 15, yStartStaysPosition - 3);
                    Console.WriteLine(stays[4]);
                    Console.SetCursorPosition(xStartStaysPosition + 40, yStartStaysPosition - 10);
                    Console.WriteLine(stays[5]);
                    Console.SetCursorPosition(xStartStaysPosition - 8, yStartStaysPosition);
                    Console.WriteLine(stays[6]);
                    Console.SetCursorPosition(xStartStaysPosition + 35, yStartStaysPosition - 3);
                    Console.WriteLine(stays[7]);
                    Console.SetCursorPosition(xStartStaysPosition + 26, yStartStaysPosition - 1);
                    Console.WriteLine(stays[8]);
                    Console.SetCursorPosition(xStartStaysPosition + 33, yStartStaysPosition - 7);
                    Console.WriteLine(stays[9]);
                    Console.SetCursorPosition(xStartStaysPosition + 50, yStartStaysPosition - 4);
                    Console.WriteLine(stays[10]);
                    Console.SetCursorPosition(xStartStaysPosition + 60, yStartStaysPosition - 5);
                    Console.WriteLine(stays[11]);

                    Console.SetCursorPosition(xStartPosition, yStartPosition);
                    Console.WriteLine("(0)");
                }
            }
        }
    }
}