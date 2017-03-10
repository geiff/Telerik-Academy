using System;
using System.Collections.Generic;
using System.Linq;
using AnimalHierarchy.Animals;
using AnimalHierarchy.Enumeration;

namespace AnimalHierarchy
{
    class AnimalHierarchyMain
    {
        static void Main()
        {
            List<Frog> frogs = new List<Frog>()
            {
                new Frog(3, "Jabka", Gender.Male),
                new Frog(3, "Jabka", Gender.Male),
                new Frog(2, "Frogche", Gender.Female)
            };

            List<Dog> dogs = new List<Dog>()
            {
                 new Dog(4, "Dog", Gender.Other),
                 new Dog(2, "Bayche", Gender.Male)
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat(1, "Cat", Gender.Female),
                new Cat(3, "Caty", Gender.Other)
            };

            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten(2, "Kitty"),
                new Kitten(5, "Kitcy")
            };

            List<Tomcat> tomcats = new List<Tomcat>()
            {
                new Tomcat(3, "Tomi"),
                new Tomcat(2, "Tomci")
            };

            List<Animal> animals = new List<Animal>();
            animals.AddRange(frogs);
            animals.AddRange(dogs);
            animals.AddRange(cats);
            animals.AddRange(kittens);
            animals.AddRange(tomcats);

            foreach (var animal in animals)
            {
                Console.Write(animal);
                animal.Sound();
            }

            double avgAge = (animals.Sum(x => x.Age))/(double) animals.Count;
            Console.WriteLine("Average age on all animals  is {0:F2}.", avgAge);
            Console.WriteLine("Average age on Frogs is {0:F2}.", Animal.CalculateAverageAge(frogs));
            Console.WriteLine("Average age on Dogs is {0:F2}.", Animal.CalculateAverageAge(dogs));
            Console.WriteLine("Average age on Cats is {0:F2}.", Animal.CalculateAverageAge(cats));
            Console.WriteLine("Average age on Kittens is {0:F2}.", Animal.CalculateAverageAge(kittens));
            Console.WriteLine("Average age on Tomcats is {0:F2}.", Animal.CalculateAverageAge(tomcats));
        }
    }
}