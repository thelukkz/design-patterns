using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    public class Fungi : PizzaElement
    {
        public override decimal GetPrice()
        {
            return 10m;
        }
    }
}
