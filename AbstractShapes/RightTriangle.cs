using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class RightTriangle:Triangle
    {
        double Leg_A { get; set; }
        double Leg_B { get; set; }
        public RightTriangle(double leg_A, double leg_B)
        {
            Leg_A = leg_A;
            Leg_B = leg_B;
            Console.WriteLine("RightTriangleConstructor:\t" + GetHashCode());
        }
        ~RightTriangle()
        {
            Console.WriteLine("RightTriangleDestructor:\t" + GetHashCode());
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(Leg_A, 2) + Math.Pow(Leg_B, 2));
        }
        public override double Height()
        {
            return (Leg_A*Leg_B)/Hypotenuse();
        }
        public override double Perimeter()
        {
            return Leg_A+Leg_B+Hypotenuse();
        }
        public override double Area()
        {
            return Leg_A*Leg_B/2;
        }
    }
}
