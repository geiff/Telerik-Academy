using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class Class
    {
        private string uniqueIdentifier;
        private string comments;
        private List<Teacher> teachers;
        private List<Student> students; 

        public Class(string uniqueIdentifier, List<Teacher> teachers, List<Student> students)
        {
            this.UniqueIdentifier = uniqueIdentifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string UniqueIdentifier { get; set; }
        public string Comments { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        /// <summary>
        /// Override ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"Class {this.UniqueIdentifier} with teachers:\n");
            foreach (var t in this.Teachers)
            {
                result.Append("--" + t.Name + "\n");
                foreach (var d in t.Disciplines)
                {
                    result.Append("----" + d + "\n");
                }
            }

            result.Append($"Class {this.UniqueIdentifier} with students:\n");
            foreach (var s in this.Students)
            {
                result.Append(s + "\n");
            }

            result.Append($"Commnets for this class are:\n--{this.Comments}");
            result.Append("\n--------------------------------------------\n");

            return result.ToString();
        }
    }
}