using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird zapdos = new Bird()
            {
                Name = "Zapdos",
                Age = 1000,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "electric",
            };

            Console.WriteLine($"{zapdos.Name} is an {zapdos.Type} pokemon that is {zapdos.Age} years old and has " +
                $"{zapdos.Legs} legs and {zapdos.Wings} wings.");
            Console.WriteLine($"Is {zapdos.Name} a vertebrate, warm blooded, and has feathers? " +
                $"{zapdos.HasBackbone}, {zapdos.IsWarmBlooded}, and {zapdos.HasFeathers}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                Name = "Smaug",
                Age = 1200,
                Legs = 4,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Erebor",
                Defense = "breathes fire"
            };

            Console.WriteLine($"{dragon.Name} is a {dragon.Age} year old dragon that lives under {dragon.Environment}," +
                $" {dragon.Defense}, and has {dragon.Legs} legs");
            Console.WriteLine($"Is {dragon.Name} a vertebrate, cold blooded, and has scales?" +
                $" {dragon.HasBackbone}, {dragon.IsColdBlooded}, and {dragon.HasScales}");
            Console.WriteLine();
        }
    }
}
