using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string otvet = "";
            while (otvet.ToLower() != "yes" && otvet.ToLower() != "no")
            {
                Console.Write("Введёте данные вручную? (yes/no): ");
                otvet = Console.ReadLine();
            }

            string[] massiveS = new string[] { };

            









        }
    }
}