namespace DecoratorPattern.Abstract
{
    public abstract class PizzaTopping : PizzaElement
    {
        protected PizzaElement _component;

        public PizzaTopping(PizzaElement component)
        {
            _component = component;
        }

        public override decimal GetPrice()
        {
            return _component.GetPrice();
        }
    }
}
