using System;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy.Animals
{
    public class Cat : Animal
    {
        public Cat(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        /// <summary>
        /// Override Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("My sounds are May May May");
        }
    }
}