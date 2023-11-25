using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class IsoscelesTriangle:Triangle
    {
        double hip;
        double botton;
        public double Hip
        {
            get { return hip; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                hip = value;
            }
        }
        public double Botton
        { 
            get { return botton; } 
            set 
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                botton = value;
            } 
        }
        public IsoscelesTriangle(double hip, double botton, int start_x, int start_y, int line_width, Color color) :
            base(start_x, start_y, line_width, color)
        {
            Hip = hip;
            Botton = botton;
        }
        public override double GetHeight()
        {
            return Math.Sqrt(Math.Pow(Hip, 2) - Math.Pow(Botton, 2) / 4);
        }
        public override double GetArea()
        {
            return Botton * GetHeight() / 2;
        }
        public override double GetPerimeter()
        {
            return Hip * 2 + Botton;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX,StartY),
                new Point(StartX+(int)Botton/2,StartY+(int)GetHeight()),
                new Point(StartX+(int)Botton,StartY),
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Бедро треугольника: {Hip}");
            Console.WriteLine($"Основание треугольника: {Botton}");
            base.Info(e);
        }
        public override void DrawHeight(PaintEventArgs e)
        {

        }
    }
}
