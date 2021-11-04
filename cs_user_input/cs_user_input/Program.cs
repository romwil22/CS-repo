using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your username: ");
            string username = Console.ReadLine();

            Console.Write("enter your ign: ");
            string ign = Console.ReadLine();

            Console.Write("enter your job: ");
            string job = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("account: " + username);
            Console.WriteLine("ign: " + ign);
            Console.WriteLine("job: " + job);

            Console.ReadLine();

        }
    }
}
