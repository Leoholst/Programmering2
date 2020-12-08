using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_Abstract
{
    abstract class Animal
    {
        public abstract void animalSound();
        public abstract void animalFood();
        public abstract void animalFeeling();
        public abstract void animalBrain();
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: G'day, can I use my creditcard?");
        }
        public override void animalFood()
        {
            Console.WriteLine("The Dog: Eats exotic dog food");
        }
        public override void animalFeeling()
        {
            Console.WriteLine("The Dog: is Alright");
        }
        public override void animalBrain()
        {
            Console.WriteLine("The Dog: has a small sized brain");
        }
    }
    class Pinguin : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pinguin says: Oi! Have you seen my tuxedo?");
        }
        public override void animalFood()
        {
            Console.WriteLine("The Pinguin: Eats fresh fish");
        }
        public override void animalFeeling()
        {
            Console.WriteLine("The Pinguin: is Happy");
        }
        public override void animalBrain()
        {
            Console.WriteLine("The Pinguin: has a medium sized brain");
        }
    }
    class Monkey : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Monkey says: Wooh, WOOH");
        }
        public override void animalFood()
        {
            Console.WriteLine("The Monkey: Feasts on fleas");
        }
        public override void animalFeeling()
        {
            Console.WriteLine("The Monkey: is Excellent");
        }
        public override void animalBrain()
        {
            Console.WriteLine("The Monkey: has a huge sized brain");
        }
    }
}
