using System;
using System.Drawing;
using PrototypePattern.Abstract;

namespace PrototypePattern.Concrete
{
    public class CourseImage : Cloneable
    {
        public Bitmap Bitmap { get; set; }

        public void Initialise()
        {
            Bitmap = (Bitmap)Image.FromFile("./Assets/laptop.png");
        }

        public override Cloneable Clone()
        {
            CourseImage clone = (CourseImage)this.MemberwiseClone();
            clone.Bitmap = (Bitmap)Bitmap.Clone();
            return clone as Cloneable;
        }

        public void Save(string filePath)
        {
            Console.WriteLine("Writing {0}", filePath);
            Bitmap.Save(filePath);
        }
    }
}
