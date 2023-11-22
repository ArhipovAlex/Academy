using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    internal class IsoscelesTriangle:Triangle
    {
        double Hip { get; set; }
        double Base { get; set; }
        public IsoscelesTriangle(double hip, double bas)
        {
            Hip= hip;
            Base= bas;
            Console.WriteLine("IsoTriangleConstructor:\t" + GetHashCode());
        }
        ~IsoscelesTriangle() 
        {
            Console.WriteLine("IsoTriangleDestructor:\t"+GetHashCode());
        }
        public override double Height()
        {
            return Math.Sqrt(Math.Pow(Hip,2)-Math.Pow(Base,2)/4);
        }
        public override double Perimeter()
        {
            return Hip*2+Base;
        }
        public override double Area()
        {
            return Base*Height()/2;
        }
    }
}
