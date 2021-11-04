using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_working_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "romwil";
            string message = "C# programming";
            Console.WriteLine("C# working with string\n");
            Console.WriteLine("Welcome to C# programming " + name);
            Console.WriteLine(message);
            Console.WriteLine("character string length "+message.Length);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.Contains("programming"));
            Console.WriteLine(message.Contains("Ccharp"));
            Console.WriteLine();

            Console.WriteLine("accessing index:\n");
            Console.WriteLine(name[0]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[4]);
            Console.WriteLine();

            Console.WriteLine(message.IndexOf("programming"));
            Console.WriteLine(message.IndexOf('#'));
            Console.WriteLine(message.IndexOf('z'));

            Console.WriteLine(message.Substring(3, 7));

            Console.ReadLine();
        }
    }
}
