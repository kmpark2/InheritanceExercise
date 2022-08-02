using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        { 
        }
        public string Color { get; set; }
        public int LifeExpectancy { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public Animal(string color, int lifeExpectancy, string name, string scientificName)
        {
            Color = color;
            LifeExpectancy = lifeExpectancy;
            Name = name;
            ScientificName = scientificName;
        } 
    }
}
