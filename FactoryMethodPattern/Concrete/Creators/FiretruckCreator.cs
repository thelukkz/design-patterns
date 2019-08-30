using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Toys;

namespace FactoryMethodPattern.Concrete.Creators
{
    class FiretruckCreator : ToyCreator
    {
        protected override Toy CreateToy() => new Firetruck();
    }
}
