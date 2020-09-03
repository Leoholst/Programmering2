using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello Niklas!");
            var age = 0;
            Console.WriteLine("How old are you?");
            var input = Console.ReadLine();
            age = int.Parse(input);
            for(var i = 0; i <age; i++)
            {
                Console.WriteLine("You're not special.");
            }

            var yourName = "";
            Console.WriteLine("What is your name?");
            input = Console.ReadLine();
            yourName = input;
            Console.WriteLine("Ah so your name is " + yourName);
            switch (yourName)
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
            */

            string[] names = new string[5];
            Console.WriteLine("Put five celebrities in order of how much you like them!");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("You think that:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("However, I think that:");
            for (int j = names.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(names[j]);
            }

            string[,,] bigArrays = new string[1, 1, 1];
            Console.WriteLine("Put your name, your age and if you're alive.");
            for (int i = 0; i < bigArrays.Length; i++)
            {
                bigArrays[i, i, i] = Console.ReadLine();
            }
            
            foreach (var bigArray in bigArrays)
            {
                Console.WriteLine(bigArray);
            }
        }
    }
}
