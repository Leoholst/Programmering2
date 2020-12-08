using System;
using System.Collections.Generic;

namespace Labb_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Monkey());
            animals.Add(new Pinguin());

            List<Accessories> accessories = new List<Accessories>();
            accessories.Add(new House());
            accessories.Add(new Ball());
            accessories.Add(new Bowl());
            accessories.Add(new Collar());
            accessories.Add(new Rug());
            accessories.Add(new Door());

            foreach (Animal item in animals)
            {
                item.animalSound();
                item.animalFood();
                item.animalBrain();
                item.animalFeeling();
            }

            foreach  (Accessories item in accessories)
            {
                item.accessoriesColor();
                item.accessoriesMaterial();
                item.accessoriesNationality();
                item.accessoriesUsed();
            }
        }
    }
}
