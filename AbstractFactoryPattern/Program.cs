using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ecosystem Africa
            ContinentFactory factory1 = new AfricaFactory();
            Ecosystem ecosystem1 = new Ecosystem(factory1);
            ecosystem1.Run();

            //ecosystem Australia
            ContinentFactory factory2 = new AustraliaFactory();
            Ecosystem ecosystem2 = new Ecosystem(factory2);
            ecosystem2.Run();

            Console.ReadKey();
        }
    }
}
