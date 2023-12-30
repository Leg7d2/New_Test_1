using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Присяжнюк Т.С., група ZIPZ-21-1\nВаріант №13\nЗавдання 3.\n");


            int N, M, S = 0;
            Console.Write("Ведіть ціле число N = ");
            while (!int.TryParse(Console.ReadLine(), out N))   
            {
                Console.Write("Помилка введення значення N. Будь ласка повторіть введення значення ще раз.\nВедіть ціле число N = ");
            }

            for (int i = 1; N >= 1; i++) 
            {
                M = (int)Math.Pow(i, N);
                N--;
                S += M;
            }
            Console.WriteLine("Сума цілих чисел = {0}", S);
        }
    }
}
