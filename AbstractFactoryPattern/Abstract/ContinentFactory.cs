using AbstractFactoryPattern.Concrete;

namespace AbstractFactoryPattern.Abstract
{
    abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
}
