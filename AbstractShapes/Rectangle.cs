using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class Rectangle : Shape
    {
        double Side_A { get; set; }
        double Side_B { get; set; }
        public Rectangle(double side_a, double side_b)
        {
            Side_A=side_a; 
            Side_B=side_b;
            Console.WriteLine("RectConstructor:\t" + GetHashCode());
        }
        ~Rectangle()
        {
            Console.WriteLine("RectDestructor:\t" + GetHashCode());
        }
        public override double Perimeter()
        {
            return 2*(Side_A + Side_B);
        }
        public override double Area()
        {
            return Side_A * Side_B;
        }
    }
}
