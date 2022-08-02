using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public double Length { get; set; }
        public string Habitat { get; set; }
        public double Weight { get; set; }
        public bool IsVenomous { get; set; }
    }
}
