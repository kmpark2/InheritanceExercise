using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var ePenguin = new Bird();
            ePenguin.Color = "black, white, and yellow";
            ePenguin.LifeExpectancy = 20;
            ePenguin.Name = "Emperor Penguin";
            ePenguin.ScientificName = "Aptenodytes forsteri";
            ePenguin.SizeOfBeak = 8.0;
            ePenguin.Height = 1.2;
            ePenguin.Wingspan = 89;
            ePenguin.Weight = 23;

            var kDragon = new Reptile();
            kDragon.Color = "black, yellow, or gray";
            kDragon.LifeExpectancy = 30;
            kDragon.Name = "Komodo Dragon";
            kDragon.ScientificName = "Varanus komodoensis";
            kDragon.Length = 2.5;
            kDragon.Habitat = "tropical savanna forests";
            kDragon.Weight = 91;
            kDragon.IsVenomous = true;

            var animalList = new List<Animal>();
            animalList.Add(ePenguin);
            animalList.Add(kDragon);

            foreach (Animal animal in animalList)
            {
                Console.WriteLine($"{animal.Name}, also known as {animal.ScientificName}, is composed of color(s): {animal.Color} and has a life expectancy of {animal.LifeExpectancy} years.");
            }

            Console.WriteLine($"{ePenguin.Name} can also grow to be {ePenguin.Height}m tall with the beak size of {ePenguin.SizeOfBeak}cm, the wingspan of {ePenguin.Wingspan}cm, and weight of {ePenguin.Weight}kg.");

            Console.WriteLine($"Meanwhile, {kDragon.Name} can grow to be {kDragon.Length}m long with the weight of {kDragon.Weight}kg. It also tends to have the habitat of {kDragon.Habitat}, and the fact that it is venomous is {kDragon.IsVenomous}.");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
