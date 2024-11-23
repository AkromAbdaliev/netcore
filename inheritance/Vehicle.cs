using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            System.Console.WriteLine("Vehicle started ..");
        }

        public void Stop()
        {
            System.Console.WriteLine("Vehicle stopped ..");
        }
    }
}