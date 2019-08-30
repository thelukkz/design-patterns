using System;
using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern.Concrete.Animals
{
    class Dingo : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name);
        }
    }
}
