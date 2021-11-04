using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Message();
            MessageName("Rom");
            PersonInfo("meann", 24, 36.4);
            Console.ReadLine();
        }

        static void Message()
        {
            Console.WriteLine("Welcome to c# tutorial");
        }

        static void MessageName(string name)
        {
            Console.WriteLine("Welcome to c# programming "+name);
        }
        static void PersonInfo(string name, int age, double temp)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Temperature: " + temp);
        }
    }
}
