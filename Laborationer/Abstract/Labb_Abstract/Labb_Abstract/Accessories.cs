using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_Abstract
{
    abstract class Accessories
    {
        public abstract void accessoriesColor();
        public abstract void accessoriesNationality();
        public abstract void accessoriesMaterial();
        public abstract void accessoriesUsed();
    }

    class House : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The House: is Yellow");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The House: is wooden");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The House: is Norwegian");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The House: is used every winter");
        }
    }
    class Ball : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The Ball: is Red");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The Ball: is plastic");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The Ball: is Spanish");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The Ball: is used daily");
        }
    }
    class Bowl : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The Bowl: is Green");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The Bowl: is metallic");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The Bowl: is Japanese");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The Bowl: is used when it's eating time");
        }
    }
    class Collar : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The Collar: is Blue");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The Collar: is Leather");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The Collar: is German");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The Collar: is used all the time");
        }
    }

    class Rug : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The Rug: is Brown");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The Rug: is soft");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The Rug: is Polish");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The Rug: is used at night");
        }
    }
    class Door : Accessories
    {
        public override void accessoriesColor()
        {
            Console.WriteLine("The Door: is Black");
        }
        public override void accessoriesMaterial()
        {
            Console.WriteLine("The Door: is Concrete");
        }
        public override void accessoriesNationality()
        {
            Console.WriteLine("The Door: is Russian");
        }
        public override void accessoriesUsed()
        {
            Console.WriteLine("The Door: is used to leave the house");
        }
    }
}
