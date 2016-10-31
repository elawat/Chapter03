using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked // compiler will warn us about overflow
            {
                try
                {
                    int x = int.MaxValue - 1;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x); //once above max, overflows to min value
                    x++;
                    WriteLine(x);
                }
                catch(OverflowException)
                {
                    WriteLine("Code overflowed but I caught the exception.");
                }

                unchecked //this disables compile-time check for overflow
                {
                    int x = int.MaxValue + 1;
                    WriteLine(x);
                    x--;
                    WriteLine(x);
                    x--;
                }
                
            }
        }
    }
}
