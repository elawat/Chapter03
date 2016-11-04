using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 5;
            //WriteLine($"{b / 0}"); //results > divebyzero exception

            double a = 5;
            WriteLine($"{a / 0}"); //results > infinity

            int x = 5;
            int y = 1;
            x = ++y; // assign to x after incrementing y
            WriteLine($"{x}");
            WriteLine($"{y}");
            x = y++; // assign to x before incrementing y
            WriteLine($"{x}");
            WriteLine($"{y}");

            //int max = 500;
            //checked
            //{
            //    for (byte i = 0; i < max; i++)
            //    {
            //        WriteLine(i);
            //    }
            //}

            WriteLine("Enter a number between 1 and 255:");
            string input1 = ReadLine();
            WriteLine("Enter a number between 1 and 255:");
            string input2 = ReadLine();
            try
            {
                int n1 = int.Parse(input1);
                int n2 = int.Parse(input2);
                WriteLine($"{n1} devided by {n2} is {n1 / n2}");
            }
            catch (FormatException) //catching specific exception
            {
                WriteLine("Input string was not in correct format.");
            }
            catch (Exception ex) //general catch for all other types of exceptions
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }


        }
    }
}
