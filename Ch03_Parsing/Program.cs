using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing - changing string to other type
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            WriteLine("How many eggs are there");
            int count;
            string inout = Console.ReadLine();
            if(int.TryParse(inout, out count)) // out required to allow TryParse to set the count when conversion works
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input");
            }

        }
    }
}
