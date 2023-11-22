using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class EquilateralTriangle:Triangle
    {
        double Side { get; set; }
        public EquilateralTriangle(double side)
        {
            Side = side;
            Console.WriteLine("EqTriangleConstructor:\t" + GetHashCode());
        }
        ~EquilateralTriangle() 
        {
            Console.WriteLine("EqTriangleDestructor:\t"+GetHashCode());
        }

        public override double Height()
        {
            return Math.Sqrt(Math.Pow(Side,2)-Math.Pow(Side/2,2));
        }
        public override double Perimeter()
        {
            return Side*3;
        }
        public override double Area()
        {
            return Math.Pow(Height(),2)*Math.Sqrt(3);
        }
    }
}
