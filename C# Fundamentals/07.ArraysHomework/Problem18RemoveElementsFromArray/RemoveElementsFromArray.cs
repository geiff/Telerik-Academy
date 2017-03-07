using System;

namespace Problem18RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] subsetLength = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                subsetLength[i] = 1;
            }

            int maxSubset = 1;


            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] >= numbers[j] && subsetLength[i] <= subsetLength[j] + 1)
                    {
                        subsetLength[i] = subsetLength[j] + 1;

                        maxSubset = Math.Max(maxSubset, subsetLength[i]);
                    }
                }
            }


            int numbersToRemove = n - maxSubset;
            Console.WriteLine(numbersToRemove);
        }
    }
} 