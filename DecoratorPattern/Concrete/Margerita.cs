using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    public class Margerita : PizzaElement
    {
        public override decimal GetPrice()
        {
            return 8m;
        }
    }
}
