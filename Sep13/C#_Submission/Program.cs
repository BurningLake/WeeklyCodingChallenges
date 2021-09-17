using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Sep13
{
    class Program
    {

        // recursive method takes in a positive integer and outputs a string of its prime factors
        // output does not have any formatting and needs another function to do so
        static string ExpressFactors(int input, int current)
        {
            // if the input is 1, then stop recursion
            if (input == 1)
                return "";

            // if input is divisible by current number, then add it to the string and repeat with the divided input
            if (input % current == 0)
                return current + " " + ExpressFactors(input/current, current);
            
            // otherwise check the next factor
            return ExpressFactors(input, current+=1);
        }

        // formats a string of prime numbers
        // currently does not introduce powers of repeated factors (ex. 2^3 will instead be written as 2 x 2 x 2)
        static string FactorFormat(string primeString)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Prime Factorization: ");
            string[] subs = primeString.Split();
            string appended = " x ";

            for (int i = 0; i < subs.Count(); i++)
            {
                if (i == subs.Count() - 2)
                    appended = "";
                result.Append(subs[i] + appended);
            }


            return result.ToString();
        }

        static void Main(string[] args)
        {
            // Create a function that takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.
            while(true)
            {
                Console.Clear();
                Console.Write("Insert Positive Integer greater than 1 to Factorize: ");
                string stringInput = Console.ReadLine();
                int input;

                // Try to parse input, invalid input if result is negative or zero
                Int32.TryParse(stringInput, out input);
                if (input <= 1)
                {
                    Console.WriteLine("Please enter a positive integer greater than 1");
                }
                else
                {
                    Console.WriteLine(FactorFormat(ExpressFactors(input, 2)));
                }

                Console.Write("Press Enter to continue: ");
                Console.ReadLine();
            }
        }
    }
}
