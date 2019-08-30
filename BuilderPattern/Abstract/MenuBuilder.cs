using BuilderPattern.Concrete;

namespace BuilderPattern.Abstract
{
    abstract class MenuBuilder
    {
        public abstract void BuildBurgerOrSalad();
        public abstract void BuildFries();
        public abstract void BuildDessert();
        public abstract void BuildDrink();
        public abstract void BuildToy();

        public abstract Menu GetResult();
    }
}
