using System;

namespace Lab_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetCustomer();
            ChooseProduct();
        }

        static void GreetCustomer()
        {
            Customer firstCustomer = new Customer();
            Console.WriteLine("Hello good sir! What is your name?");
            var inputName = Console.ReadLine();
            firstCustomer.customer_Name = inputName;
            Console.WriteLine("Greetings " + firstCustomer.customer_Name);
        }

        static void ChooseProduct()
        {
            Product chooseYourCar = new Product();
            Console.WriteLine("What is your dream car model?");
            var inputModel = Console.ReadLine();
            chooseYourCar.car_Model = inputModel;
            Console.WriteLine("Then what is your dream color of your car?");
            var inputColor = Console.ReadLine();
            chooseYourCar.car_Color = inputColor;
            Console.WriteLine("What is your dream car year of production?");
            var inputYear = Console.ReadLine();
            chooseYourCar.car_Year = int.Parse(inputYear);
            Console.WriteLine("So, you want a " + chooseYourCar.car_Year + " " + chooseYourCar.car_Color + " " + chooseYourCar.car_Model + "?");
        }
    }
}
