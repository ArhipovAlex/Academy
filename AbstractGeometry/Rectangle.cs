using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Rectangle : Shape
    {

        double width;
        double height;
        public double Width
        {
            get { return width; }
            set 
            {
                if(value< MIN_LENGTH) value= MIN_LENGTH; 
                if(value> MAX_LENGTH) value= MAX_LENGTH;
                width = value; 
            }
        }
        public double Height
        { get { return height; } 
            set 
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                height = value;
            } 
        }
        public Rectangle(
            int width, int height,
            int start_x, int start_y, int line_width, Color color
            ):base (start_x, start_y, line_width, color)
        {
            Width= width;
            Height= height;
        }
        public override double GetArea()
        {
            return Width*Height;
        }
        public override double GetPerimeter()
        {
            return (Width+Height)*2;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Height);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Высота: {Height}");
            base.Info(e);
        }
    }
}
