using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTypeSystem.Enumerations;

namespace CommonTypeSystem
{
    class StartUp
    {
        static void Main()
        {
            Student fStudent = new Student("Pesho", "P.", "Peshev", 66121, "dsds", 54545, "pesho@abv.bg", "Asd", Specialty.Mathematics,
                University.SofiaUniversity, Faculty.GeographyFaculty);
            Student sStudent = new Student("Gesho", "P.", "Peshev", 56121, "dsds", 54545, "pesho@abv.bg", "Asd", Specialty.Mathematics,
                University.SofiaUniversity, Faculty.GeographyFaculty);
            Student tStudent = new Student("Gesho", "P.", "Peshev", 36121, "dsds", 54545, "pesho@abv.bg", "Asd", Specialty.Mathematics,
               University.SofiaUniversity, Faculty.GeographyFaculty);

 
            //Student clone = fStudent.Clone();
            //Console.WriteLine("Firt -> {0}", fStudent);
            //Console.WriteLine("Clone -> {0}", clone);
            //fStudent.MiddleName = "F";
            //Console.WriteLine("Firt2 -> {0}", fStudent);
            //Console.WriteLine("Clone2 -> {0}", clone);
            //clone.MiddleName = "S..";
            //Console.WriteLine("Firt3 -> {0}", fStudent);
            //Console.WriteLine("Clone3 -> {0}", clone);

            List<Student> students = new List<Student>() {fStudent, sStudent, tStudent};
        
            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
