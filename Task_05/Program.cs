/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;
using System.Globalization;

namespace Task_05
{
    class Program
    {
        const string notTriangleMessage = "not a triangle";

        static void Main(string[] args)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU", true);
            double x = double.Parse(Console.ReadLine()),
                   y = double.Parse(Console.ReadLine()),
                   z = double.Parse(Console.ReadLine());
            string result;
            double epsilon = 0.001;
            if (((y + z - x) > epsilon && (x + z - y) > epsilon && (x + y - z) > epsilon))
            {
                result = Sqare(x, y, z).ToString();
            }
            else
            {
                result = notTriangleMessage;
            }
            Console.WriteLine(result);
        }

        static double Sqare(double a, double b, double c)
        {
            double p = 1 / 2 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
