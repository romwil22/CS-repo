using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountName = "romwil";
            string personFullname = "romwil pilapil";
            int personAge = 28;
            string personEmail = "sample.emailtest@gmail.com";

            Console.WriteLine("Account Information:");
            Console.WriteLine("Account name:"+accountName);
            Console.WriteLine("Fullname: "+personFullname);
            Console.WriteLine("Age: "+personAge);
            Console.WriteLine("Email: "+personEmail);
            Console.WriteLine("");

            accountName = "mary ann";
            personFullname = "mary ann natividad";
            personAge = 24;
            personEmail = "sample.emailtest@gmail.com";

            Console.WriteLine("Account Information:");
            Console.WriteLine("Account name:" + accountName);
            Console.WriteLine("Fullname: " + personFullname);
            Console.WriteLine("Age: " + personAge);
            Console.WriteLine("Email: " + personEmail);

            Console.ReadLine();
        }
    }
}
