/*Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.*/
using System;
using System.Collections.Generic;

namespace Problem03CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<string> cards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool isContains = cards.Contains(input);

            Console.WriteLine(isContains ? "yes {0}" : "no {0}", input);
        }
    }
}