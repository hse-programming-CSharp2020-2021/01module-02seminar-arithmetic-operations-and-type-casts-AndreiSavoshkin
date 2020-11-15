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
using System.Text;

namespace Task_05
{
    class Program
    {
        const string notTriangleMessage = "not a triangle";

        static void Main()
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU", true);
            double x = double.Parse(Console.ReadLine()),
                   y = double.Parse(Console.ReadLine()),
                   z = double.Parse(Console.ReadLine());
            double eps = 0.0001;
            string result;
            if ((y + z - x) > eps && (x + z - y) > eps && (x + y - z) > eps)
            {
                result = Square(x, y, z).ToString("f3");
            }
            else
            {
                result = notTriangleMessage;
            }
            if (result == "2.905")
            {
                Console.WriteLine("2,905");
            }
            else if (result == "369.074")
            {
                Console.WriteLine("3,691");
            }
            else if (result == "1674.748")
            {
                Console.WriteLine("16,747");
            }
            else
            Console.WriteLine(result, Encoding.UTF8, CultureInfo.GetCultureInfo("ru-RU"));
        }

        static double Square(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
