/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4
{
    class Program
    {
        public static string ReverseNumber(int x)
        {
            return ($"{x % 10}{x % 100 / 10}{x / 100 % 10}{x / 1000}");
        }

        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(x));
        }
    }
}
