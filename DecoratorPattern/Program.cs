using DecoratorPattern.Concrete;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //margerita with extra ham
            var pizza = 
                new WithExtraHam(
                new Margerita());
            var price = pizza.GetPrice();
            Console.WriteLine("Margerita + ham: {0}", price);

            pizza =
                new WithExtraHam(
                new WithExtraCheese(
                new Fungi()));
            price = pizza.GetPrice();
            Console.WriteLine("Fungi + ham, cheese: {0}", price);

            Console.ReadKey();
        }
    }
}
