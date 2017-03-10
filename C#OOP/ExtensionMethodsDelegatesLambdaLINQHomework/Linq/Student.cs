using System.Collections.Generic;

namespace Linq
{
    public class Student
    {
        public Student(string firstName, string lastName, string facultyNumber, string phoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return
                $"{this.FirstName} {this.LastName} {this.FacultyNumber} {this.PhoneNumber} {this.Email} {this.Marks} {this.GroupNumber}";
        }
    }
}