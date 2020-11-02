/*
 * Задача : 
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
 * Корни выводит с точностью до 2-х знаков после запятой.
 * Учесть (как хотите) возможность появления комплексных корней.
 * !!! Оператор if не применять. !!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5
 * 13
 * 6
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -0,60
 * -2,00
 * -------test_2-------
 * complex roots
 * --------------------
 * 
 * Корни выводятся в отдельных строках. Если нет вещественных вывести сообщение "complex roots"
 */

using System;
using System.Globalization;

namespace Task_03
{
    class Program
    {
        const string complexRootsMessage = "complex roots";

        public static string SolveEquation(double A, double B, double C)
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU", true);
            double D;
            string result;
            D = B * B - 4 * A * C;
            result = A == 0
                    ? (B == 0
                        ? (C == 0
                            ? "Уравнение имеет бесконечно много корней."
                            : "Уравнение корней не имеет.")
                        : (-1 * C / B).ToString("F2"))
                    : (D > 0
                        ? ((-B + Math.Sqrt(D)) / (2 * A)).ToString("F2") + Environment.NewLine + ((-B - Math.Sqrt(D)) / (2 * A)).ToString("F2")
                        : (D == 0
                            ? (-B / (2 * A)).ToString("F2")
                            : complexRootsMessage)
                  );
            return result;
        }

        public static void Main()
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU", true);
            double A = double.Parse(Console.ReadLine()),
                       B = double.Parse(Console.ReadLine()),
                       C = double.Parse(Console.ReadLine());

            Console.WriteLine(SolveEquation(A, B, C));
        }
    }
}
