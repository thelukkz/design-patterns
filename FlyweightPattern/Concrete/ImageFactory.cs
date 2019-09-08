using FlyweightPattern.Abstract;
using System;
using System.Collections.Generic;

namespace FlyweightPattern.Concrete
{
    class ImageFactory
    {
        private Dictionary<string, BaseImage> flyweights = new Dictionary<string, BaseImage>();

       public BaseImage GetFlyweight(string filename)
        {
            BaseImage flyweight = null;

            if (flyweights.ContainsKey(filename))
            {
                flyweight = flyweights[filename] as BaseImage;
                Console.WriteLine("Returning cached image {0}", filename);
            }
            else
            {
                flyweight = new Image(filename);
                flyweights.Add(filename, flyweight);
                Console.WriteLine("Instantiating new image {0}", filename);
            }

            return flyweight;
        }
    }
}
