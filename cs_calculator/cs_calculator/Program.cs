using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply Calculator:\n");

            //ENTER USER INPUT
            Console.Write("Enter a number: ");
            double number0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //OUTPUT
            Console.Write("product: ");
            Console.WriteLine(number0 * number1);

            Console.ReadLine();

        }
    }
}
