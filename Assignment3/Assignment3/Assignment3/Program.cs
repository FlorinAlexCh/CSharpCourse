using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = Console.ReadLine();
            PrintValue(value1);
        }

        static void PrintValue(string message)
        {
            string result = string.IsNullOrWhiteSpace(message) ? Console.ReadLine() : message;
            string result1 = string.IsNullOrWhiteSpace(result) ? Console.ReadLine() : result;
            string result2 = string.IsNullOrWhiteSpace(result1) ? "Nu am continut" : result1;
            Console.WriteLine(result2);
        }

    }
}
