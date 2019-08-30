using AbstractFactoryPattern.Abstract;

namespace AbstractFactoryPattern
{
    class Ecosystem
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public Ecosystem(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void Run()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
