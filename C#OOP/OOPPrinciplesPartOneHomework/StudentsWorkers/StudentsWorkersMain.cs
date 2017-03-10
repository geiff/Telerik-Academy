using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsWorkers
{
    class StudentsWorkersMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Peshev", 5),
                new Student("Kolio", "Peshev", 2),
                new Student("Pesho", "Kolev", 4),
                new Student("Tedi", "Tei", 6),
                new Student("Des", "Deseva", 3),
                new Student("Natali", "Rol", 6),
                new Student("Aleks", "Aneva", 4),
                new Student("Gosho", "Goshev", 5),
                new Student("Stamat", "Stamatov", 2),
                new Student("Stamat", "Stoev", 5)
            };

            var resultStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Students are:");
            foreach (var student in resultStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-----------------------------------------------");

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Pesho", "Nikolov", 100.20m, 4),
                new Worker("Kolio", "Kolev", 200.0m, 5),
                new Worker("Pesho", "Stoinov", 200.50m, 6),
                new Worker("Tedi", "Sol", 200.0m, 5),
                new Worker("Des", "Zas", 200.0m, 5),
                new Worker("Natali", "Nels", 350m, 8),
                new Worker("Aleks", "Qneva", 450.0m, 8),
                new Worker("Gosho", "Stoev", 150m, 5),
                new Worker("Stamat", "Rolev", 150m, 5),
                new Worker("Stamat", "Kolev", 200.0m, 5)
            };

            var resultatWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Workers are:");
            foreach (var worker in resultatWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("---------------------------------------");

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var resultatHuman = humans.OrderBy(w => w.FirstName).ThenBy(w => w.LastName);
            Console.WriteLine("Humans are:");
            foreach (var human in resultatHuman)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}