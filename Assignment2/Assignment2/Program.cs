using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrie textul");
            string wordCount = Console.ReadLine();
            string[] count = wordCount.Split(' ');
            Console.WriteLine("Numarul de cuvinte: " +count.Length);
        }
    }
}
