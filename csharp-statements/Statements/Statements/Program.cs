using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("N=");

            for (int i = 0;i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i > 10)
                {
                    int shouldContinue = ReadNumber("Mai continuati? 0=Nu, 1=DA");
                    if (shouldContinue == 0)
                    {
                        break;
                    }
                }
            }



        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
        static void If_Simple()
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
        static void Switch()
        {
            Random randomizer = new Random();
            int i = randomizer.Next(0, 100);
            switch (i % 2)
            {
                case 0:
                    Console.WriteLine($"{i} is Even");
                    break;

                case 1:
                    Console.WriteLine($"{i} is Odd");
                    break;

                default:
                    Console.WriteLine("Valorea nu e corecta");
                    break;
            }
        }
        static void IfExerciseWithComplexMenu()
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. File");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. View");
            Console.Write("Your option is: ");
            string level1Option = Console.ReadLine();

            if (string.Equals(level1Option, "1", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(level1Option, "file", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please select a sub-option: ");
                Console.WriteLine("1.1 New");
                Console.WriteLine("1.2 Open");
                Console.WriteLine("1.3 Save");
                Console.Write("Your option is: ");
                string level2Option = Console.ReadLine();
                if (string.Equals(level2Option, "1.1", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(level2Option, "New", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 1.1 NEW");
                }
                else if (string.Equals(level2Option, "1.2", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(level2Option, "Open", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 1.2 Open");
                }
                else if (string.Equals(level2Option, "1.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "Save", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 1.3 Save");
                }
                Console.WriteLine($"Your Option '{level2Option}' is not valid");
            }
            else if (string.Equals(level1Option, "2", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(level1Option, "Edit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please select a sub-option: ");
                Console.WriteLine("2.1 Cut");
                Console.WriteLine("2.2 Copy");
                Console.WriteLine("2.3 Paste");
                Console.Write("Your option is: ");
                string level2Option = Console.ReadLine();
                if (string.Equals(level2Option, "2.1", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(level2Option, "Cut", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 2.1 Cut");
                }
                else if (string.Equals(level2Option, "2.2", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(level2Option, "Copy", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 2.2 Copy");
                }
                else if (string.Equals(level2Option, "2.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "Paste", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 2.3 Paste");
                }
                Console.WriteLine($"Your Option '{level2Option}' is not valid");
            }
            else if (string.Equals(level1Option, "3", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(level1Option, "View", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please select a sub-option: ");
                Console.WriteLine("3.1 Solution Explorer");
                Console.WriteLine("3.2 Git changes");
                Console.WriteLine("3.3 Cloud Explorer");
                Console.Write("Your option is: ");
                string level2Option = Console.ReadLine();
                if (string.Equals(level2Option, "3.1", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(level2Option, "Solution Explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 3.1 Solution Explorer");
                }
                else if (string.Equals(level2Option, "3.2", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(level2Option, "Git changes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 3.2 Git changes");
                }
                else if (string.Equals(level2Option, "3.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "Cloud Explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected 3.3 Cloud Explorer");
                }
                else
                {
                    Console.WriteLine($"Your Option '{level2Option}' is not valid");
                }
            }
            else
            {
                Console.WriteLine($"Your Option '{level1Option}' is not valid");
            }
        }

     }
            }
