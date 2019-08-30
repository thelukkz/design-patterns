using System;
using System.Drawing;
using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern.Concrete.Toys
{
    class Firetruck : Toy
    {
        public override int GetPowderQuantity()
        {
            return 40;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(2);
        }

        public override Color GetColor()
        {
            return Color.Red;
        }
    }
}
