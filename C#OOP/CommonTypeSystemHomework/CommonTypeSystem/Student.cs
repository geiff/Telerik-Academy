using System;
using CommonTypeSystem.Contarcts;

namespace CommonTypeSystem
{
    using Enumerations;

    public class Student : IStudent, ICloneable, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private int mobilePhone;
        private string email;
        private string course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, int ssn, string address, int mobilePhone,
            string email, string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public string Address { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() + this.MiddleName.GetHashCode() + this.LastName.GetHashCode() +
                this.Ssn.GetHashCode() + this.Address.GetHashCode() + this.MobilePhone.GetHashCode() + this.Email.GetHashCode() +
                this.Course.GetHashCode() + this.Specialty.GetHashCode() + this.University.GetHashCode() + this.Faculty.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;
            int result = 0;
            result = this.FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = this.Ssn.CompareTo(other.Ssn);
            }

            return result;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student student = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.MobilePhone, 
                this.Email, this.Course, this.Specialty, this.University, this.Faculty);
            Student cloneStudent = new Student(student.FirstName, student.MiddleName, student.LastName, student.Ssn, student.Address,
                student.MobilePhone, student.Email, student.Course, student.Specialty, student.University, student.Faculty);
            return cloneStudent;
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;

            if (this.FirstName.Equals(other.FirstName) && this.MiddleName.Equals(other.MiddleName) &&
                this.LastName.Equals(other.LastName) &&
                this.Ssn == other.Ssn && this.Address.Equals(other.Address) && this.MobilePhone == other.MobilePhone &&
                this.Email.Equals(other.Email) && this.Specialty == other.Specialty &&
                this.University == other.University && this.Faculty == other.Faculty)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.MiddleName} {this.LastName} {this.Ssn}" +
                   $" {this.Address} {this.MobilePhone} {this.Email} {this.Course}" +
                   $" {this.Specialty} {this.University} {this.Faculty}";
        }

       public static bool operator ==(Student firstStudent, Student lastStudent)
       {
           return Student.Equals(firstStudent, lastStudent);
       }

        public static bool operator !=(Student firstStudent, Student lastStudent)
        {
            return !Student.Equals(firstStudent, lastStudent);
        }
    }
}