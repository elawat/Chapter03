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

            int max = 500;
            checked
            {
                for (byte i = 0; i < 500; i++)
                {
                    WriteLine(i);
                }
            }


        }
    }
}
