using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is your age");
            string inout = Console.ReadLine();
            try // error is caught, no error displayed
            {
                int age = int.Parse(inout);
                WriteLine($"You are {age} age old.");
            }
            catch(FormatException) //catching specific exception
            {
                WriteLine("The age you entered in not a valied numer format.");
            }
            // order of catching exceptions is important - related to inheritance hierarchy of the exceptions types
            catch (OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (Exception ex) //general catch for all otehr types of exceptions
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");

           

        }
    }
}
