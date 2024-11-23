using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.SOLID.OCP
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Width * Length;
        }
    }
}