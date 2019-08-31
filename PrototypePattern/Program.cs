using System;
using PrototypePattern.Concrete;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseImage prototype = new CourseImage();
            prototype.Initialise();

            CourseImageMaker maker = new CourseImageMaker();

            CourseImage blueprint = maker.CreateImage(prototype, "./Assets/course_image_1.png");
            blueprint.Save("blueprint.png");

            CourseImage threads = maker.CreateImage(prototype, "./Assets/course_image_2.png");
            threads.Save("threads.png");

            CourseImage memory = maker.CreateImage(prototype, "./Assets/course_image_3.png");
            memory.Save("memory.png");

            Console.ReadKey();
        }
    }
}
