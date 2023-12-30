using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Присяжнюк Т.С., група ZIPZ-21-1\nВаріант №13\nЗавдання 3\n");
            int x, y, parni = 0, nparni = 0, vid = 0, dod = 0;
            Console.Write("вводить цілі числа:\n-> ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Помилка введення значення. Будь ласка повторіть введення значення ще раз.\n-> ");
            }
            while (x != 0)
            { 
                y = x % 2;
                if (y == 0)
                {
                    parni++;
                }
                else
                {
                    nparni++;
                }
                if (x > 0)
                {
                    dod++;
                }
                else
                {
                    vid++;
                }
                Console.Write("-> ");
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Помилка введення значення. Будь ласка повторіть введення значення ще раз.\n-> ");
                }
            }
            Console.WriteLine("\nПарних чисел: {0}", parni);
            Console.WriteLine("Непарних чисел: {0}", nparni);
            Console.WriteLine("Додатних чисел: {0}", dod);
            Console.WriteLine("Від’ємних чисел: {0}", vid);
        }
    }
}
