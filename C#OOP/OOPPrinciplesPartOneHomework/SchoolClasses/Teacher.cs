using System.Collections.Generic;

namespace SchoolClasses
{
    public class Teacher:Person
    {
        private List<Discipline> disciplines; 
        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines { get; set; }

        /// <summary>
        /// Override ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Teacher {this.Name} with {this.Disciplines}";
        }
    }
}