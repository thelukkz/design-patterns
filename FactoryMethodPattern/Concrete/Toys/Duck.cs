using System;
using System.Drawing;
using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern.Concrete.Toys
{
    class Duck : Toy
    {
        public override int GetPowderQuantity()
        {
            return 20;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(1);
        }

        public override Color GetColor()
        {
            return Color.Yellow;
        }
    }
}
