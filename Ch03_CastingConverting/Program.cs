using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch03_CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting and ceonverting
            double c = 9.8;
            int d = (int)c; //explicit casting

            long e = long.MaxValue; 
            int f = (int)e; //any too big value when casting wll get set to -1
            WriteLine($"e is {e} and f is {f}");

            double a = 9.5;
            int b = ToInt32(a); //ToInt method from System.Covert namespace - rounding
            WriteLine($"a is {a} and b is {b}");
            b = (int)a; //casting - trimming
            WriteLine($"a is {a} and b is {b}");

            //Rounding
            double k = 9.5;
            double l = 10.5; // .5 round down if non-decimal part is even - Banker's Rounding rule
            WriteLine($"k is {k} and ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l} and ToInt(l) is {ToInt32(l)}");

            //ToString
            int no = 12;
            WriteLine(no.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString()); //cannot be reresented as string, returns their namespace and type name

        }
    }
}
