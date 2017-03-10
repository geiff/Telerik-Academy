namespace Problem03RangeExceptions
{
    using System;
    using Contracts;

    public class Person : IPerson
    {
        private string name;
        private int age;
        private DateTime birthDate;
        private readonly InvalidRangeException<int> EXEPTION_AGE;
        private readonly InvalidRangeException<DateTime> EXEPTION_BIRTH_DATE;

        public Person(string name, int age, DateTime birthDate)
        {
            this.EXEPTION_AGE = new InvalidRangeException<int>("Age can'not be in range",
                -100, -1);
            this.EXEPTION_BIRTH_DATE = new InvalidRangeException<DateTime>("Date cann't be in range",
                new DateTime(1700, 01, 01), new DateTime(1899, 12, 31));
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthDate;           
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cann't be null or empty");
                }

                this.name = value;
            }
        }
        
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= EXEPTION_AGE.StartRangeDefinition && value <= EXEPTION_AGE.EndRangeDefinition)
                {
                    Console.WriteLine(EXEPTION_AGE.ErrorMessage + " [" + EXEPTION_AGE.StartRangeDefinition + " to "
                        + EXEPTION_AGE.EndRangeDefinition + "].");
                }

                this.age = value;
            }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set
            {
                if (value >= EXEPTION_BIRTH_DATE.StartRangeDefinition && value <= EXEPTION_BIRTH_DATE.EndRangeDefinition)
                {
                    Console.WriteLine(EXEPTION_BIRTH_DATE.ErrorMessage + " [" + EXEPTION_BIRTH_DATE.StartRangeDefinition + " to "
                        + EXEPTION_BIRTH_DATE.EndRangeDefinition + "].");
                }

                this.birthDate = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old and birth date is {this.BirthDate}.";
        }
    }
}