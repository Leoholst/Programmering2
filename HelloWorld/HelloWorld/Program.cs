using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");
            var age = 0;
            Console.WriteLine("How old are you?");
            var input = Console.ReadLine();
            age = int.Parse(input);

            var name = "";
            Console.WriteLine("What is your name?");
            input = Console.ReadLine();
            name = input;
            Console.WriteLine("Ah so your name is " + name);

            bool aliveOrNot = true;
            if(age > 100)
            {
                Console.WriteLine("sorry you're dead...");
            }
            else
            {
                Console.WriteLine("You seem alive...");
            }

        }
    }
}
