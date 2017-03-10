using System.Collections.Generic;
using System.Linq;
using AnimalHierarchy.Enumeration;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Animals
{
    /// <summary>
    /// Abstact class
    /// </summary>
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender gender;
        protected Animal(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"I am {this.Name} and I am on {this.Age} years old and my gender is \"{this.Gender}\". ";
        }

        public abstract void Sound();

        /// <summary>
        /// Method caculate average age
        /// </summary>
        /// <param name="animals"></param>
        /// <returns></returns>
        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            double averageAge = animals.Average(animal => animal.Age);
            return averageAge;
        }
    }
}