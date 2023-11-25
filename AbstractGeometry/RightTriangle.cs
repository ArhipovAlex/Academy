using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class RightTriangle:Triangle
    {
        double leg_a;
        double leg_b;
        public double Leg_A 
        { 
            get { return leg_a; } 
            set 
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                leg_a = value; 
            }
        }
        public double Leg_B
        { 
            get { return leg_b; }
            set 
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                leg_b = value;
            }
        }
        public RightTriangle(double leg_a, double leg_b, int start_x, int start_y, int line_width, Color color):
            base(start_x, start_y, line_width, color)
        {
            Leg_A= leg_a;
            Leg_B= leg_b;
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(Leg_A, 2) + Math.Pow(Leg_B, 2));
        }
        public override double GetHeight()
        {
            return (Leg_A * Leg_B) / Hypotenuse();
        }
        public override double GetArea()
        {
            return Leg_A * Leg_B / 2;
        }
        public override double GetPerimeter()
        {
            return Leg_A + Leg_B + Hypotenuse();
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX,StartY),
                new Point(StartX,StartY+(int)Leg_B),
                new Point(StartX+(int)Leg_A,StartY+(int)Leg_B),
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Катет А: {Leg_A}");
            Console.WriteLine($"Катет В: {Leg_B}");
            Console.WriteLine($"Гипотенуза: {Hypotenuse()}");
            base.Info(e);
        }
    }
}
