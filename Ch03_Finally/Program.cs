using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Ch03_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = null;
            StreamWriter writer = null;
            try
            {
                file = File.OpenWrite(@"c:\Code\file.txt"); //this created the file when does not exist
                writer = new StreamWriter(file);
                writer.WriteLine("Hello C#!");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if(writer != null)
                {
                    writer.Dispose();
                    WriteLine("The writer's unmanaged resourse have been disposed.");
                }
                if(file != null)
                {
                    file.Dispose();
                    WriteLine("The file's unmanaged resourse have been disposed.");
                }
            }

            using (FileStream file2 = File.OpenWrite(@"c:\Code\file2.txt"))
            {
                using (StreamWriter writer2 = new StreamWriter(file2))
                {
                    try
                    {
                        writer2.WriteLine("Hello");
                    }
                    catch(Exception ex)
                    {
                        WriteLine($"{ex.GetType()} says {ex.Message}");
                    }
                } // automatically calls Dispose if the object is not null
            } //automatically calls Dispose if the object is not null
        }
    }
}
