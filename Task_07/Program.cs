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

namespace Task_07
{
    class Program
    {
        public static string IntegerAndFractionalPartsNumber(double x)
        {
            int integerX = (int)x;
            return integerX.ToString() + Environment.NewLine + ((x - Math.Truncate(x)) * 10).ToString("F2");
        }
        public static string RootAndSquareNumber(double x)
        {
            if (x < 0)
            {
                return (x * x).ToString("F2");
            }
            else
            {
                return Math.Sqrt(x).ToString("F2") + Environment.NewLine + (x * x).ToString("F2");
            }
        }

        public static void Main()
        {
            double numberInput = double.Parse(Console.ReadLine());
            Console.WriteLine(RootAndSquareNumber(numberInput));
            Console.WriteLine(IntegerAndFractionalPartsNumber(numberInput));
        }
    }
}
