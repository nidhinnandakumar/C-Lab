using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{

        internal class Trapezium : Shape
        {
            double side1, side2,side3;

            public Trapezium (double a,double b, double c)
            {
                this.side1 = a;
                this.side2 = b;
                this.side3 = c;

        }
            public override double Area()
            {
                return 0.5*(side1+side2)*side3;
            }
        }
    }