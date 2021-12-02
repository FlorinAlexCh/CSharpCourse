using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"D:\Work\git\CSharpCourse\Assignment1\text-used.txt");
            string s = text.Replace("|", " ");
            string[] m = s.Split(" ");
            string message = @$"{m[0]} {m[1]} {m[2]}{m[3]} {m[4]} {m[5]} {m[6]} {m[7]} {m[8]} {m[9]} {m[10]} {m[11]}";
            Console.WriteLine(message);
        }

    }
}
