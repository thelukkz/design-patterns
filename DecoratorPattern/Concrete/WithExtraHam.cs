using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    class WithExtraHam : PizzaTopping
    {
        public WithExtraHam(PizzaElement component) : base(component)
        {

        }

        public override decimal GetPrice()
        {
            var basePrice = base.GetPrice();
            return basePrice + 1.50m;
        }
    }
}
