/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using Microsoft.Win32;
using System;
using System.Globalization;

namespace Task_01
{
    class Program
    {
        static double Pow(double x, int k)
        {
            if (k == 1)
            {
                return x;
            }
            else if (k % 2 == 0)
            {
                double y = Pow(x, k / 2);
                return y * y;
            }
            else
            {
                return x * Pow(x, k - 1);
            }
        }
        public static double CountPolynom(double x)
        {
            double result = 12 * Pow(x, 4) + 9 * Pow(x, 3) - 3 * Pow(x, 2) + 2 * x - 4;
            return result;
        }

        public static void Main(string[] args)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(CountPolynom(x).ToString("F2", CultureInfo.GetCultureInfo("ru-RU")));
        }
    }
}
