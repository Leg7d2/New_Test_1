using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Присяжнюк Т.С., група ZIPZ-21-1\nВаріант №13\nЗавдання 3.\n");

            uint N, K, M, S = 0;
            Console.Write("Введіть ціле додатнє число N = ");
            while (!uint.TryParse(Console.ReadLine(), out N) || N == 0)
            {
                Console.Write("Помилка введення значення N. Будь ласка повторіть введення значення ще раз.\nВведіть ціле додатнє число N = ");
            }
            Console.Write("Введіть ціле додатнє число K = ");
            while (!uint.TryParse(Console.ReadLine(), out K) || K == 0)
            {
                Console.Write("Помилка введення значення K. Будь ласка повторіть введення значення ще раз.\nВведіть ціле додатнє число K = ");
            }

            for (uint i = 1; N >= i; i++)
            {
                M = (uint)Math.Pow(i, K);
                S += M;
            }
            Console.WriteLine("Сума цілих додатніх чисел = {0}", S);
        }
    }
}
