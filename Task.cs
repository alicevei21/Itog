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

            if (otvet.ToLower() == "yes")
            {
                int n = InputN("Введите количество элементов массива: ");
                massiveS = new string[n];
                for (int i = 0; i < massiveS.Length; i++)
                {
                    Console.Write($" Введите {i + 1} строку: ");
                    massiveS[i] = Console.ReadLine();
                }
            }
            else
            {
                massiveS = new string[] { "hello", "2", "world", ":-)" };
                Console.WriteLine($"{PrintM(massiveS)}");
            }

            int lengthLimit = 3;

            int numbersItems = CheckM(massiveS, lengthLimit);

            string[] newMassiveS = new string[numbersItems];

            FillNewM(massiveS, newMassiveS, lengthLimit);

            Console.WriteLine($"{PrintM(newMassiveS)}");

            void FillNewM(string[] oldArray, string[] newArray, int lengthLimit2)
            {
                int temp = 0;
                for (int i = 0; i < oldArray.Length; i++)
                {
                    if (oldArray[i].Length <= lengthLimit2)
                    {
                        newArray[temp] = oldArray[i];
                        temp++;
                    }
                }
            }

            int CheckM(string[] array, int lengthLimit2)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= lengthLimit2) result++;
                }
                return result;
            }


            string PrintM(string[] array)
            {
                string result = string.Empty;

                result = "[ ";
                for (int i = 0; i < array.Length; i++)
                {
                    result += $"{array[i],1}";
                    if (i < array.Length - 1) result += ", ";
                }
                result += " ]";
                return result;
            }

            int InputN(string input)
            {
                Console.Write(input);
                int outt = Convert.ToInt32(Console.ReadLine());
                return outt;
            }

        }
    }
}