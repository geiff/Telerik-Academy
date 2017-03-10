using System;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy.Animals
{
    public class Dog : Animal
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        /// <summary>
        /// Override Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Bay Bay Bay");
        }
    }
}