using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays\n");

            int[] numbers = { 12, 26, 1, 22, 11 };
            
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[1]);
            numbers[1] = 7;
            Console.WriteLine(numbers[1]);

            string[] accounts = new string[4];
            accounts[0] = "romwil22";
            accounts[1] = "romwil11";
            accounts[2] = "mheann0726";
            Console.WriteLine(accounts[0]);
            Console.WriteLine(accounts[1]);
            Console.WriteLine(accounts[2]);


            Console.ReadLine();
        }
    }
}
