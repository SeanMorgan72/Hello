using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite food to eat?");
            var food = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Your favorite food to eat is " + food + ".");
        }

    }
}
