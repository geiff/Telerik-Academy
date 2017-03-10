using System;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base(age, name, Gender.Male)
        {
        }

        /// <summary>
        ///Override Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("TomcatMay TomcatMay TomcatMay");
        }
    }
}