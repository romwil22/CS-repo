using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_mad_libs_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Libs Game\n");
            Console.WriteLine("fill-in the blank");
            Console.WriteLine("Roses are _____");
            Console.WriteLine("_____ is blue");
            Console.WriteLine("I Love _____");
            Console.WriteLine();

            string color, pluralNoun, celebrity;

            Console.Write("Roses are _____(color): ");
            color = Console.ReadLine();
            Console.WriteLine("Roses are " + color);
            Console.Write("_____(plural noun) is blue: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine(pluralNoun+ " is blue");
            Console.Write("I Love _____(celebrity): ");
            celebrity = Console.ReadLine();
            Console.WriteLine("I Love "+celebrity);
            Console.WriteLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " is blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();

        }
    }
}
