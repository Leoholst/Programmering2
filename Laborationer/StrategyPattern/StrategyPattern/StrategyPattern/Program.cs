using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for choosing Volvo, what model do you want?");
            Console.WriteLine("Press 1 for the Volvo 240");
            Console.WriteLine("Press 2 for the Volvo 760");
            Console.WriteLine("Press 3 for the Volvo S70");

            static string ChooseModel()
            {
              return Console.ReadLine();
            }

            
        }
    }
}
