using System;

namespace Day2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name
            Console.WriteLine("Hello. What is your name?");
            string name = Console.ReadLine();

            // Number Input
            Console.WriteLine($"{name}, will you enter a number between 1 and 100 please.");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 100)
            {

                // Number Output
                if (number % 2 == 1)
                {
                    Console.WriteLine($"{name}, your number is {number} and is odd");
                }
                else if (number % 2 == 0 && number >= 2 && number < 25)
                {
                    Console.WriteLine($"{name}, your number is even and less than 25");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine($"{name}, your number is even");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{name}, your number is even");
                }
                else if (number % 2 == 1 && number > 60)
                {
                    Console.WriteLine($"{name}, your number is odd and greater than 60");
                }
            } else
            {
                Console.WriteLine($"{name}, please enter a number between 1 and 100");
            }
        }
    }
}
