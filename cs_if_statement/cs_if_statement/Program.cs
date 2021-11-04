using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool above18 = false;
            bool adult = false;

            if(adult)
            {
                Console.WriteLine("Welcome to c# casino\n");
            }
            else
            {
                Console.WriteLine("Sorry, adult player can play\n");
            }

            if(adult && above18)
            {
                Console.WriteLine("Your ready to play\n");
            }
            else if(adult && !above18)
            {
                Console.WriteLine("You can play under minor games\n");
            }
            else
            {
                Console.WriteLine("You Cannot play, get lost!\n");
            }


            Console.ReadLine();
        }
    }
}
