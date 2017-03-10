namespace SchoolClasses
{
    /// <summary>
    /// Abstact class Person
    /// </summary>
     public abstract class Person
    {
        private string name;
        private string comments;

        protected Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Comments { get; set; }
    }
}