using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.polymorphism
{
    public class Zebra : Animal
    {
        public string Group { get; set; }

        public override void AnimalSound()
        {
            System.Console.WriteLine("Zebra makes sound: honk honk");
        }
        public override void AnimalEats()
        {
            System.Console.WriteLine("Zebra eats grass");
        }

    }
}