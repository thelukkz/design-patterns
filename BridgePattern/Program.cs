using BridgePattern.Abstract;
using BridgePattern.Concrete.DrawApis;
using BridgePattern.Concrete.Shapes;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line drawn using OpenGL commands:");
            Shape line = new Line(new OpenGLApi());
            line.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle drawn using SVG commands:");
            Shape rectangle = new Rectangle(new SvgApi());
            rectangle.Draw();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
