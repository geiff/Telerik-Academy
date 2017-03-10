using System;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy.Animals
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name, Gender.Female)
        {
        }

        /// <summary>
        /// Override Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("KitMay KitMay KitMay");
        }
    }
}