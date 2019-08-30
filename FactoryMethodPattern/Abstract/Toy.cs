using System;
using System.Drawing;

namespace FactoryMethodPattern.Abstract
{
    abstract class Toy
    {
        public abstract int GetPowderQuantity();
        public abstract TimeSpan GetHeatingTime();
        public abstract Color GetColor();
    }
}
