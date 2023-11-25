using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle:Shape, IHaveRadius
    {
        double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                radius = value;
            }
        }
        public Circle
            (
            int radius,
            int start_x, int start_y, int line_width, Color color
            ) : base(start_x, start_y, line_width, color)
        {
            Radius = radius;
        }
        public double Diameter()
        {
            return 2 * Radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double GetPerimeter()
        {
            return Math.PI * 2 * Radius;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            System.Drawing.Rectangle rectangle1 = new System.Drawing.Rectangle(StartX, StartY, (int)Diameter(), (int)Diameter());
            RectangleF convertedRectangle = rectangle1;
            e.Graphics.DrawEllipse(pen, convertedRectangle);
            DrawRadius(e);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус: {Radius}");
            base.Info(e);
        }
        public double GetRadius()
        { 
            return Radius; 
        }
        public void DrawRadius(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX+ (float)GetRadius(), StartY, StartX + (float)GetRadius(), StartY + (float)GetRadius());
        }
    }
}
