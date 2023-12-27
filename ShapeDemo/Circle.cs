using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Circle : Shape
    {
        double radius;
        public Circle(double Radius)
        {
            this.radius = Radius;   
        }
        public override double Area()
        {
            //pi *r*r
            return Math.PI * radius * radius;
        }
    }
}
