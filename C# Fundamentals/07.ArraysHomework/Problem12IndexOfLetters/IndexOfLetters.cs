/*Write a program that creates an array containing all letters from the alphabet (a-z). 
 Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;

namespace Problem12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            List<char> letter = new List<char>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                letter.Add(i);
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letter.Count; j++)
                {
                    if (word[i] == letter[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}