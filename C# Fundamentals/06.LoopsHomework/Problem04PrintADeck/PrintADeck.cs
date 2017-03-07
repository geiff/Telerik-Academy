/*Write a program that reads a card sign(as a char) from the console and generates and prints all possible 
 cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). 
 The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.*/
using System;

namespace Problem04PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] cards = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            int position = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == input)
                {
                    position = i;
                }
            }

            for (int i = 0; i <= position; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
            }
        }
    }
}