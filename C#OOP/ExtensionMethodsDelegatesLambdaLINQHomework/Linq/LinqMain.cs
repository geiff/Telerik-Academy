using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class LinqMain
    {
        static void Main()
        {
            Person[] people = new Person[]
            {
                new Person("Pesho", "Peshev", 25),
                new Person("Gosho", "Goshev", 31),
                new Person("Pesho", "Kolev", 18),
                 new Person("Angel", "Dimov", 24),
                new Person("Leni", "Konev", 30),
                new Person("Soni", "Koleva", 17)
            };

            Console.WriteLine("Problem 3.");
            people.Where(name => string.Compare(name.FirstName, name.LastName) < 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nProblem 4.");
            people.Where(student => student.Age >= 18 && student.Age <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nProblem 5.");
            people.OrderBy(name => name.FirstName)
                .ThenByDescending(name => name.LastName)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nProblem 6.");
            int[] numbers = new[] { 5, 4, 3, 7, 2, 21, 42 };
            numbers.Where(x => x % 3 == 0 && x % 7 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            List<Student> students = new List<Student>()
           {
                new Student("Pesho", "Peshev", "252506", "656565", "pesho@abv.bg", new List<int>() {2, 2, 2}, 1),
                new Student("Gosho", "Goshev", "155226", "02825525", "gosho@abv.bg", new List<int>() {6, 5, 2}, 2),
                new Student("Pesho", "Kolev", "525306", "+359255355", "pesho1@mail.bg", new List<int>() {4, 3, 2}, 1),
                new Student("Angel", "Dimov", "520505", "025255663", "angel@abv.bg", new List<int>() {6, 6, 2}, 2),
                new Student("Leni", "Konev", "520256", "5585", "leni@mail.bg", new List<int>() {2, 4, 2}, 2),
                new Student("Soni", "Koleva", "822506", "826662", "soni@abv.bg", new List<int>() {4, 6, 5}, 1)
           };

            List<Group> department = new List<Group>()
            {
                new Group(1, "Mathematics"),
                new Group(2, "C#")
            };

            Console.WriteLine("\nProblem 9.");
            var resultStudent = from st in students
                                where st.GroupNumber == 2
                                orderby st.FirstName
                                select st.FirstName;

            foreach (var st in resultStudent)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("\nProblem 10.");
            students.Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FirstName));

            Console.WriteLine("\nProblem 11.");
            students.Where(x => x.Email.Contains("abv.bg"))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.Email
                })
                .ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nProblem 12.");
            students.Where(x => x.PhoneNumber.StartsWith("02") || x.PhoneNumber.StartsWith("+3592"))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.PhoneNumber
                })
                .ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nProblem 13.");
            students
                .Where(student => student.Marks.Any(m => m == 6))
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    Marks = string.Join(", ", x.Marks)
                }).ToList().ForEach(x => Console.WriteLine(x.FullName + " " + x.Marks));


            Console.WriteLine("\nProblem 14.");
            students
                .Where(student => student.Marks.Count(m => m == 2) == 2)
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    Marks = string.Join(", ", x.Marks)
                }).ToList().ForEach(x => Console.WriteLine(x.FullName + " " + x.Marks));

            Console.WriteLine("\nProblem 15.");
            students
                .Where(student => student.FacultyNumber.EndsWith("06"))
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    x.FacultyNumber
                }).ToList().ForEach(x => Console.WriteLine(x.FullName + " " + x.FacultyNumber));

            Console.WriteLine("\nProblem 16.");
            var resultatQuery = from student in students
                join departm in department
                    on student.GroupNumber equals departm.GroupNumber
                    where departm.DepartmentName == "Mathematics"
                                select new {student.FirstName, student.LastName, student.GroupNumber, departm.DepartmentName};

            foreach (var resultat in resultatQuery)
            {
                Console.WriteLine(resultat.FirstName + " " + resultat.LastName + " " + resultat.GroupNumber + " " + resultat.DepartmentName);
            }

            Console.WriteLine("\nProblem 17.");
            string[] text = new[] { "Test", "TextArray", "Text1" };
            text.Where(x => x == MaxLenght(text)).ToList().ForEach(x => Console.WriteLine(x));


            Console.WriteLine("\nProblem 18.");
            var groupStudent = from student in students
                               group new { Name = student.FirstName + " " + student.LastName } by student.GroupNumber
                               into studentGroup
                               orderby studentGroup.Key
                               select studentGroup;
            
            foreach (var st in groupStudent)
            {
                Console.Write("Group Number {0} -> ", st.Key);
                foreach (var s in st)
                {
                    Console.Write(s.Name + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nProblem 19.");
            var group = students.GroupBy(x => x.GroupNumber).OrderBy(x => x.Key);

            foreach (var st in group)
            {
                Console.Write("Group Number {0} -> ", st.Key);
                foreach (var s in st)
                {
                    Console.Write(s.FirstName + " " + s.LastName + "; ");
                }

                Console.WriteLine();
            }
        }

        public static string MaxLenght(string[] text)
        {
            string result = String.Empty;

            foreach (string t in text)
            {
                if (t.Length > result.Length)
                {
                    result = t;
                }
            }

            return result;
        }
    }
}