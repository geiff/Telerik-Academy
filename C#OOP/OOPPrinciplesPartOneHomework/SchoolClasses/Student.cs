namespace SchoolClasses
{
    public class Student : Person
    {
        private int classNumber;
        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; set; }

        /// <summary>
        /// Override ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"--{this.ClassNumber}. {this.Name}";
        }
    }
}