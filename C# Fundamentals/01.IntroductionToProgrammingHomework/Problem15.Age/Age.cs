/*Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.*/

using System;
using System.Globalization;

namespace Problem15.Age
{
    class Age
    {
        static void Main()
        {
            string textInput = Console.ReadLine();

            string dateFormat = "MM.dd.yyyy";
            DateTime birtdate = DateTime.ParseExact(textInput, dateFormat, CultureInfo.InvariantCulture);
            DateTime nowDate = DateTime.Now;
            int age;

            int year = birtdate.Year;
            int month = birtdate.Month;

            if (nowDate.Month < month)
            {
                age = nowDate.Year - year - 1;
                Console.WriteLine(age);
            }
            else
            {
                    age = nowDate.Year - year;
                    Console.WriteLine(age);   
               
            }

            Console.WriteLine(age + 10);
        }
    }
}