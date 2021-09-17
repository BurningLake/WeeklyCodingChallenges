using System;

namespace Sep6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that returns the string "something" joined with a space " " and the given argument a.

            Console.Clear();
            Console.Write("Hello, please enter argument: ");
            string a = Console.ReadLine();
            Console.WriteLine(GiveMeSomething(a));
        }

        static string GiveMeSomething(string input)
        {
            return "something " + input;
        }
    }
}
