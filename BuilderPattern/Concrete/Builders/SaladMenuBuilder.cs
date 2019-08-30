using BuilderPattern.Abstract;

namespace BuilderPattern.Concrete.Builders
{
    class SaladMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();

        public override void BuildBurgerOrSalad()
        {
            _menu.Add("Salad");
        }

        public override void BuildFries() { }

        public override void BuildDessert()
        {
            _menu.Add("Dessert");
        }

        public override void BuildDrink()
        {
            _menu.Add("Drink");
        }

        public override void BuildToy() { }

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}
