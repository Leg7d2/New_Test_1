using System;
using System.Text;

namespace ConsoleApp1
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
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Присяжнюк Т.С., група ZIPZ-21-1\nВаріант №13\nЗавдання 1.\n");
            double y, x, z, s, m, n;
            while (true) 
            {
                try 
                {
                    Console.Write("Введіть дробое значення х = ");
                    x = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка введення значення х. Будь ласка повторіть введення значення ще раз!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введіть дробое значення y = ");
                    y = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка введення значення y. Будь ласка повторіть введення значення ще раз!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введіть дробое значення z = ");
                    z = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка введення значення z. Будь ласка повторіть введення значення ще раз!");
                }
            }
            
            m = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4);
            n = Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));
            s = m / n;
            Console.WriteLine("Результат обчислення: s = {0}\n", s);


        }
    }
}

