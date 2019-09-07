using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    class WithExtraCheese : PizzaTopping
    {
        public WithExtraCheese(PizzaElement component) : base(component)
        {

        }

        public override decimal GetPrice()
        {
            var basePrice = base.GetPrice();
            return basePrice + 1m;
        }
    }
}
