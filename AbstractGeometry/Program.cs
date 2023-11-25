using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics= Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle rectangle = 
                new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop, 
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, rectangle);
            Rectangle rect = new Rectangle(200,150,300,50,1, Color.AliceBlue);
            rect.Info(e);

            Square square = new Square(50, 350, 250, 2, Color.Red);
            square.Info(e);

            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(50, 700, 50, 3, Color.Green);
            equilateralTriangle.Info(e);

            RightTriangle rightTriangle = new RightTriangle(50,50,700, 150, 3 , Color.Blue);
            rightTriangle.Info(e);

            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(70, 40, 700, 250, 3, Color.Yellow);
            isoscelesTriangle.Info(e);

            Circle circle = new Circle(50, 700, 350, 3, Color.Magenta);
            circle.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
