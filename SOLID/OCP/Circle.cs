using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.SOLID.OCP
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}