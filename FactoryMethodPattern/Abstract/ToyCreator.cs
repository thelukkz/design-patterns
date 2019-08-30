using System;
using System.Drawing;

namespace FactoryMethodPattern.Abstract
{
    abstract class ToyCreator
    {
        protected abstract Toy CreateToy();

        public void MakeToy()
        {
            Toy toy = CreateToy();
            int grams = toy.GetPowderQuantity();
            TimeSpan heatingTime = toy.GetHeatingTime();
            Color color = toy.GetColor();

            PreparePowder(grams);
            SelectMold(toy);
            InjectPowder(grams);
            HeatMold(heatingTime);
            ExtractToy();
            PaintToy(color);
        }

        #region private

        private void PreparePowder(int grams)
        {
            Console.WriteLine("Preparing {0} grams of powder", grams);
        }

        private void SelectMold(Toy toy)
        {
            Console.WriteLine("Selecting mold {0}", toy.GetType().Name);
        }

        private void InjectPowder(int grams)
        {
            Console.WriteLine("Injecting {0} grams of powder", grams);
        }

        private void HeatMold(TimeSpan duration)
        {
            Console.WriteLine("Heating for {0} minutes", duration.TotalMinutes);
        }

        private void ExtractToy()
        {
            Console.WriteLine("Extracting toy");
        }

        private void PaintToy(Color color)
        {
            Console.WriteLine("Painting toy {0}", color.Name);
        }

        #endregion
    }
}
