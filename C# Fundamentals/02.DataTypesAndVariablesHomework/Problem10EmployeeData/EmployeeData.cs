﻿/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

using System;

namespace Problem10EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Tomas";
            string lastName = "Tomov";
            sbyte age = 28;
            char gender = 'm';
            long idNumber = 8306112507;
            uint emplNumber = 27569999;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(idNumber);
            Console.WriteLine(emplNumber);
        }
    }
}