using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class Circle:Shape
    {
        double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Console.WriteLine("CircleConstructor:\t"+GetHashCode());
        }
        ~Circle() 
        {
            Console.WriteLine("CircleDestructor:\t" + GetHashCode());
        }
        public override double Perimeter()
        {
            return Math.PI*2*Radius;
        }
        public override double Area()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
        public double Diameter()
        {
            return 2*Radius;
        }
    }
}
