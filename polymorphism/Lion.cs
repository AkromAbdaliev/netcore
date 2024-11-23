using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.polymorphism
{
    public class Lion : Animal
    {
        public string Pride { get; set; }

        public override void AnimalSound()
        {
            System.Console.WriteLine("Lion makes sound: argh argh");
        }
        public override void AnimalEats()
        {
            System.Console.WriteLine("Lion eats meat");
        }
    }
}