using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_return_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareResult = Square(4);
            Console.WriteLine("4^2 = " + squareResult);
            int cudeResult = Cude(3);
            Console.WriteLine("3^3 = " + cudeResult);
            Console.ReadLine();
        }

        static int Square(int number)
        {
            int square = number * number;
            return square;
        }

        static int Cude(int number)
        {
            int square = number * number * number;
            return square;
        }

    }
}
