using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DakotaBaldwinHelloWorld_1032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collect name from user
            Console.WriteLine("Please enter your name.");
            string creatorName = Console.ReadLine();

            // Inject usrName variable into Console string
            Console.WriteLine("Hi World, " + creatorName + " programmed me! Thank you " + creatorName + "!");
            Console.ReadKey();
        }
    }
}
