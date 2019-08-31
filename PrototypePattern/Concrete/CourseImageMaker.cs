using System.Drawing;

namespace PrototypePattern.Concrete
{
    public class CourseImageMaker
    {
        public CourseImage CreateImage(CourseImage prototype, string imagePath)
        {
            CourseImage image = (CourseImage)prototype.Clone();

            using (var blend = Image.FromFile(imagePath))
            {
                using (var canvas = Graphics.FromImage(image.Bitmap))
                {
                    canvas.DrawImage(blend, 115, 32);
                }
            }

            return image;
        }
    }
}
