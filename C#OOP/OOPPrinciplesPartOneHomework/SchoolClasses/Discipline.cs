namespace SchoolClasses
{
    public class Discipline
    {
        private string name;
        private int countLectures;
        private int countExercises;
        private string comments;

        public Discipline(string name, int countLectures, int countExercises)
        {
            this.Name = name;
            this.CountLectures = countLectures;
            this.CountExercises = countExercises;
        }

        public string Name { get; set; }
        public int CountLectures { get; set; }
        public int CountExercises { get; set; }
        public string Comments { get; set; }

        /// <summary>
        /// Override ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Discipline {this.Name} with {this.CountLectures} count lectures and {this.CountExercises} count exercises";
        }
    }
}