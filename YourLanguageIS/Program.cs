using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLanguageIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nНапишите, какой язык распахнул перед вами ворота в мир программирования.\n");

            string user_types = Console.ReadLine();

            Console.WriteLine("\nИмя вашего швейцара - " + user_types);
            Console.ReadKey();
        }
    }
}
