using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class Square:Shape
    {
        double Side { get; set; }
        public Square(double side) 
        {
            Side=side;
            Console.WriteLine("SquareConstructor:\t" + GetHashCode());
        }
        ~Square()
        {
            Console.WriteLine("SquareDestructor:\t"+GetHashCode());
        }
        public override double Perimeter()
        {
            return 4*Side;
        }
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

    }
}
