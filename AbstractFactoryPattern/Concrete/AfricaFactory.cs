using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete.Animals;

namespace AbstractFactoryPattern.Concrete
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
