/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_07
{
    class Program
    {
        public static string IntegerAndFractionalPartsNumber(double x)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            int integerX = (int)x;
            return integerX.ToString() + Environment.NewLine + ((x - Math.Truncate(x)) * 10).ToString(CultureInfo.GetCultureInfo("ru-RU"));
        }
        public static string RootAndSquareNumber(double x)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            if (x < 0)
            {
                return (x * x).ToString("F2", CultureInfo.GetCultureInfo("ru-RU"));
            }
            else
            {
                return Math.Sqrt(x).ToString("F2", CultureInfo.GetCultureInfo("ru-RU")) + 
                       Environment.NewLine + 
                       (x * x).ToString("F2", CultureInfo.GetCultureInfo("ru-RU"));
            }
        }

        public static void Main()
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            double numberInput = double.Parse(Console.ReadLine());
            Console.WriteLine(RootAndSquareNumber(numberInput));
            Console.WriteLine(IntegerAndFractionalPartsNumber(numberInput));
        }
    }
}
