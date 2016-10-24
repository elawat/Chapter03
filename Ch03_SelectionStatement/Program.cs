using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            if (args.Length == 0)
            {
                WriteLine("There are no arguments");
            }
            else
            {
                WriteLine("There is at least one argument");
            }

        //switch-case
        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1: //must be a lietal value
                    WriteLine("One");
                    break; // jump to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
            }

            //while
            int x = 0;
                while (x < 10 )
                {
                WriteLine(x);
                x++;
            }

            WriteLine(x);

            // do while
            x = 0;
            do
            {
                WriteLine(x);
                x++;
            } while (x < 10);

            WriteLine();

            //for
            for (int y = 0; y<10; y++)
            {
                WriteLine(y);
            }

            //foreach
            string[] names = { "Kiwi", "Synek", "Malpka" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            //compiler turns foreach statement is something liek below
            //IEnumerator e = names.GetEnumerator();
            //while(e.MoveNext())
            //{
            //    string name = (string)e.Current; //Current is read only
            //    WriteLine($"{name}has {name.Length} characters.");
            //}


                
        }
    }
}
