using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace AbstractGeometry
{
    abstract internal class Shape
    {
        const int START_X_MIN_VALUE = 10;
        const int START_Y_MIN_VALUE = 10;
        const int START_X_MAX_VALUE = 1000;
        const int START_Y_MAX_VALUE = 800;
        const int LINE_WIDTH_MIN_VALUE = 1;
        const int LINE_WIDTH_MAX_VALUE = 20;
        protected const int MIN_LENGTH = 10;
        protected const int MAX_LENGTH = 500;
        int start_x;
        int start_y;
        int line_width;
        public Color Color { get; set; }
        public int StartX
        {
            get { return start_x; }

            set
            {
                if (value < START_X_MIN_VALUE) value = START_X_MIN_VALUE;
                if (value > START_X_MAX_VALUE) value = START_X_MAX_VALUE;
                start_x = value;
            }
        }
        public int StartY
        {
            get { return start_y; }
            set
            {
                if (value < START_Y_MIN_VALUE) value = START_Y_MIN_VALUE;
                if (value > START_Y_MAX_VALUE) value = START_Y_MAX_VALUE;
                start_y = value;
            }
        }
        public int LineWidth
        {
            get { return line_width; }
            set
            {
                if(value < LINE_WIDTH_MIN_VALUE) value = LINE_WIDTH_MIN_VALUE;
                if(value> LINE_WIDTH_MAX_VALUE) value = LINE_WIDTH_MAX_VALUE;
                line_width = value;
            }
        }
        public Shape(int start_x, int start_y, int line_width, Color color)
        {
            StartX = start_x;
            StartY = start_y;
            LineWidth = line_width;
            Color = color;
            
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Draw(e);
        }
    }
}
