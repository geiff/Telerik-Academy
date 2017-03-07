using System;

namespace Problem03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] oneStr = Console.ReadLine().ToCharArray();
            char[] twoStr = Console.ReadLine().ToCharArray();

            bool isResult = false;
            for (int i = 0; i < Math.Min(oneStr.Length, twoStr.Length); i++)
            {
                if (oneStr[i] < twoStr[i])
                {
                    Console.WriteLine("<");
                    isResult = true;
                    break;
                }

                if (oneStr[i] > twoStr[i])
                {
                    Console.WriteLine(">");
                    isResult = true;
                    break;
                }
            }

            if (!isResult)
            {
                bool isEqual = true;
                if (oneStr.Length < twoStr.Length)
                {
                    Console.WriteLine("<");
                    isEqual = false;
                }

                if (oneStr.Length > twoStr.Length)
                {
                    Console.WriteLine(">");
                    isEqual = false;
                }

                if (isEqual)
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}