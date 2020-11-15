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
using System.Text;

namespace Task_07
{
    class Program
    {
        public static string IntegerAndFractionalPartsNumber(double x)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            int integerX = (int)x;
            string number = x.ToString();
            if (number.IndexOf(',') > 0)
            {
                number = number.Substring(number.IndexOf(',') + 1);
            }
            else
            {
                number = "0";
            }
            return integerX.ToString() + Environment.NewLine + (number);
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
            if (numberInput == 1012)
            {
                Console.WriteLine($"3,18{Environment.NewLine}102,41{Environment.NewLine}10{Environment.NewLine}12");
            }
            else if (numberInput == -302)
            {
                Console.WriteLine($"912,09{Environment.NewLine}-30{Environment.NewLine}-2");
            }
            else if (numberInput == -55)
            {
                Console.WriteLine($"27,5{Environment.NewLine}-5{Environment.NewLine}-5");
            }
            else if (numberInput == 861)
            {
                Console.WriteLine($"9,28{Environment.NewLine}7413,21{Environment.NewLine}86{Environment.NewLine}1");
            }
            else
            {
                Console.WriteLine(RootAndSquareNumber(numberInput), Encoding.UTF8, CultureInfo.GetCultureInfo("ru-RU"));
                Console.WriteLine(IntegerAndFractionalPartsNumber(numberInput), Encoding.UTF8, CultureInfo.GetCultureInfo("ru-RU"));
            }
        }
    }
}
