/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        public static void ValuesMax(ref int n)
        {
            // Вспомогательные переменные
            int a1, a2, a3;
            int x = n / 100,
                y = n / 10 % 10,
                z = n % 10;
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
            a2 = x + y + z - a1 - a3;
            n = 100 * a3 + 10 * a2 + a1;
            n = 100 * a3 + 10 * a2 + a1;
        }

        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            ValuesMax(ref x);
            Console.WriteLine(x);
        }
    }
}
