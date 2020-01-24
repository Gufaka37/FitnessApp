using Fitness.BL.Controller;
using System;


namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FitnessApplication");

            Console.WriteLine("Enter the user name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the gender:");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter the Birth Date:");
            var birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
