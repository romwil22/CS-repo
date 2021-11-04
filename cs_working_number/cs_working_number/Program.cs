using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_working_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 22 + 26;
            int different = 26 - 1;
            int product = 5 * 4;
            double division = 15 / 2.0;
            int modulus = 10 % 2;
            int incrementNumer = 1;
            incrementNumer++;
            int decrementNumber = 2;
            decrementNumber--;

            Console.WriteLine(sum);
            Console.WriteLine(different);
            Console.WriteLine(product);
            Console.WriteLine(division);
            Console.WriteLine(modulus);
            Console.WriteLine(incrementNumer);
            Console.WriteLine(decrementNumber);
            Console.WriteLine();

            Console.WriteLine("precedence of operation\n");
            Console.WriteLine((7-3) * 10 + 4);
            Console.WriteLine();

            int absoluteValue = Math.Abs(-15);
            double pow = Math.Pow(4, 3);
            double sqrt = Math.Sqrt(49);
            Console.WriteLine("Math methods\n");
            Console.WriteLine(absoluteValue);
            Console.WriteLine(pow);
            Console.WriteLine(sqrt);
            Console.WriteLine(Math.Max(2, 5));
            Console.WriteLine(Math.Min(5, 2));
            Console.WriteLine(Math.Round(1.2));
            Console.WriteLine(Math.Round(14.7));

            Console.ReadLine();
        }
    }
}
