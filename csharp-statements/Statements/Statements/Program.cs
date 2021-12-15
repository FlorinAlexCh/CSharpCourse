using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int i = randomizer.Next(0, 100);

            bool isEven = i % 2 == 0;
            if (isEven)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is not even");
            }
        }
    }
}
