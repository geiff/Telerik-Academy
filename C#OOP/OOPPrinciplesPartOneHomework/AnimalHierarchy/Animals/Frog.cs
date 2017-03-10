using System;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy.Animals
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        /// <summary>
        /// Override Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Kvag Kvag Kvag");
        }
    }
}