using BuilderPattern.Abstract;
using BuilderPattern.Concrete;
using BuilderPattern.Concrete.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDirector director = new MenuDirector();

            //create burger menu
            MenuBuilder builder1 = new BurgerMenuBuilder();
            director.Construct(builder1);
            Menu menu1 = builder1.GetResult();
            Console.WriteLine("Burger menu: {0}", menu1);

            //create kids menu
            MenuBuilder builder2 = new KidsMenuBuilder();
            director.Construct(builder2);
            Menu menu2 = builder2.GetResult();
            Console.WriteLine("Burger menu: {0}", menu2);

            //create salad menu
            MenuBuilder builder3 = new SaladMenuBuilder();
            director.Construct(builder3);
            Menu menu3 = builder3.GetResult();
            Console.WriteLine("Burger menu: {0}", menu3);

            //Result
            //Burger menu: Burger, Fries, Dessert, Drink
            //Burger menu: Burger, Fries, Drink, Toy
            //Burger menu: Salad, Dessert, Drink

            Console.ReadKey();
        }
    }
}
