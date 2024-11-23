using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.polymorphism
{
    public class Hyena : Animal
    {
        public string Clan { get; set; }

        public override void AnimalSound()
        {
            System.Console.WriteLine("Hyena makes sound: whoop whoop");
        }
        public override void AnimalEats()
        {
            System.Console.WriteLine("Hyena eats meat");
        }
    }
}