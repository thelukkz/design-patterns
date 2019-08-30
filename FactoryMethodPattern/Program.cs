using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Creators;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyCreator creator = null;

            //create firetruck
            Console.WriteLine("Creating a firetruck toy:");
            creator = new FiretruckCreator();
            creator.MakeToy();

            //create a duck
            Console.WriteLine("Creating a duck toy:");
            creator = new DuckCreator();
            creator.MakeToy();

            //create a superman
            Console.WriteLine("Creating a superman toy:");
            creator = new SupermanCreator();
            creator.MakeToy();

            //Result:
            //Creating a firetruck toy:
            //Preparing 40 grams of powder
            //Selecting mold Firetruck
            //Injecting 40 grams of powder
            //Heating for 2 minutes
            //Extracting toy
            //Painting toy Red
            //Creating a duck toy:
            //Preparing 20 grams of powder
            //Selecting mold Duck
            //Injecting 20 grams of powder
            //Heating for 1 minutes
            //Extracting toy
            //Painting toy Yellow
            //Creating a superman toy:
            //Preparing 20 grams of powder
            //Selecting mold Superman
            //Injecting 20 grams of powder
            //Heating for 1 minutes
            //Extracting toy
            //Painting toy Blue

            Console.ReadKey();
        }
    }
}
