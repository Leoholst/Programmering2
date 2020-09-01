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
            for(var i = 0; i <age; i++)
            {
                Console.WriteLine("You're not special.");
            }

            var name = "";
            Console.WriteLine("What is your name?");
            input = Console.ReadLine();
            name = input;
            Console.WriteLine("Ah so your name is " + name);
            switch (name)
            {
                case "Leo":
                    Console.WriteLine("You have a beautiful name!");
                    break;

                case "Fabian":
                    Console.WriteLine("I'm sorry for you");
                    break;

                case "Hugo":
                    Console.WriteLine("Ugh, ew");
                    break;
            }

            
            var mentalHealth = false;
            while(mentalHealth == false)
            {
                Console.WriteLine("How are you?");
                input = Console.ReadLine();
                var mood = input;
                if (mood == "good" || mood == "fine" || mood == "great" || mood == "amazing")
                {
                    mentalHealth = true;
                }
            }

            Console.WriteLine("Are you alive?");
            input = Console.ReadLine();
            var DeadOrNot = input;
            bool aliveOrNot = true;
            if(age > 100)
            {
                Console.WriteLine("You suggest that "+ DeadOrNot +". But I'm sorry to tell you, you're dead...");
            }
            else
            {
                Console.WriteLine(DeadOrNot + " You seem alive...");
            }

        }
    }
}
