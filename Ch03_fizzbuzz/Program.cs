using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            double remainder;
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                remainder = i % 3;
                if (remainder > 0) //not divisible by 3
                {
                    remainder = i % 5;
                    if (remainder > 0) //not divisible by 5
                    {
                        Write($"{i}, ");
                    }
                    else
                    {
                        Write("buzz, ");
                    }
                }
                else
                {
                    remainder = i % 5;
                    if (remainder > 0) //not divisible by 5
                    {
                        Write("fizz, ");
                    }
                    else
                    {
                        Write("fizzbuzz ");
                    }

                }

                
            }

            for (int i = 1; i < 101; i++) Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", i % 3 * i % 5 == 0 ? 0 : i, i % 3, i % 5);

            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

        }
    }
}
