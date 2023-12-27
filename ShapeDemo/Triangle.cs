using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Triangle : Shape
    {
        double Breadth, Height;

        public Triangle(double breadth, double height)
        {
            this.Breadth = breadth;
            this.Height = height;
        }
        public override double Area()
        {
            return 0.5 * (Breadth * Height);
        }
    }
}