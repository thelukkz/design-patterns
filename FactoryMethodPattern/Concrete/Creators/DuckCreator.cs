using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Toys;

namespace FactoryMethodPattern.Concrete.Creators
{
    class DuckCreator : ToyCreator
    {
        protected override Toy CreateToy() => new Duck();
    }
}
