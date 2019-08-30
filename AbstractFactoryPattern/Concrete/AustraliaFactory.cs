using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Concrete.Animals;

namespace AbstractFactoryPattern.Concrete
{
    class AustraliaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Kangaroo();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Dingo();
        }
    }
}
