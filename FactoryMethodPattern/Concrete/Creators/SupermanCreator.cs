using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Toys;

namespace FactoryMethodPattern.Concrete.Creators
{
    class SupermanCreator : ToyCreator
    {
        protected override Toy CreateToy() => new Superman();
    }
}
