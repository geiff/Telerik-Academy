using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class SchoolClassesMain
    {
        public static void Main()
        {
            List<Discipline> disciplinesFirst = new List<Discipline>();
            disciplinesFirst.Add(new Discipline("Mathematics", 5, 3));
            disciplinesFirst.Add(new Discipline("Biology", 4, 2));

            List<Discipline> disciplinesSeond = new List<Discipline>();
            disciplinesSeond.Add(new Discipline("History", 5, 3));
            disciplinesSeond.Add(new Discipline("Biolagy", 4, 2));

            List<Discipline> disciplinesThird = new List<Discipline>();
            disciplinesThird.Add(new Discipline("Mathematics", 5, 3));
            disciplinesThird.Add(new Discipline("History", 4, 2));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("g-n Peshev", disciplinesFirst));
            teachers.Add(new Teacher("g-n Goshev", disciplinesSeond));
            teachers.Add(new Teacher("g-n Kolev", disciplinesThird));

            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho Petkov", 1));
            students.Add(new Student("Gosho Petkov", 2));
            Class classA = new Class("A", teachers, students);
            classA.Comments = "Verry good class";

            Class classB = new Class("B",
                           new List<Teacher>()
                           {
                               new Teacher("g-n Peshev", disciplinesFirst),
                               new Teacher("g-n Goshev", disciplinesSeond)
                           }, 
                           new List<Student>()
                           {
                               new Student("Koluo Kolev", 1),
                               new Student("Tedi Aleks", 2),
                               new Student("Rosi Bosi", 3)
                           });
            classB.Comments = "Good class";
            School schools = new School(new List<Class>() {classA, classB});

            Console.WriteLine(schools);
        }
    }
}