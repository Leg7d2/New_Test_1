using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Присяжнюк Т.С., група ZIPZ-21-1\nВаріант №13\nЗавдання 2.\n");

            Console.WriteLine("Введіть числа a, b, c для квадратного рівняння ax^2 + bx + c = 0");

            double a, b, c;
            while (true)
            {
                Console.Write("Введіть значення a = ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                else
                    Console.WriteLine("Помилка введення значення a. Будь ласка повторіть введення значення ще раз.");
            }

            Console.Write("Введіть значення b = ");
            while (!double.TryParse(Console.ReadLine(), out b))              //Вирішив спробувати іншим способом
            {
                Console.Write("Помилка введення значення b. Будь ласка повторіть введення значення ще раз.\nВведіть значення b = ");
            }

            Console.Write("Введіть значення c = ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Помилка введення значення c. Будь ласка повторіть введення значення ще раз.\nВведіть значення c = ");
            }

            double discriminant = b * b - 4 * a * c;
            Console.WriteLine("Дискримінант = {0}", discriminant);

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Розв'язки: x1 = {0}, x2 = {1}",x1, x2);
            }

            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Розв'язок: x = {0}",x );
            }

            if (discriminant < 0)
            {
                Console.WriteLine("Розв'язків немає.");
            }
        }
    }
}             

  
