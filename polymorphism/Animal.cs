using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.polymorphism
{
    public class Animal
    {
        public string Family { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual void AnimalSound()
        {
            System.Console.WriteLine("Animal makes a sound");
        }

        public virtual void AnimalEats()
        {
            System.Console.WriteLine("Animal eats a food");
        }
    }
}