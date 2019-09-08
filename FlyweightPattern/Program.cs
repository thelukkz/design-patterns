using FlyweightPattern.Concrete;
using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var renderer = new WebPageRenderer();
            renderer.Render();

            Console.ReadKey();
        }
    }
}
