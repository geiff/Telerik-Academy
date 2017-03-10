namespace StudentsWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; set; }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Student {this.FirstName} {this.LastName} with grade - {this.Grade}";
        }
    }
}