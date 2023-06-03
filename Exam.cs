using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsHomework
{
    public class Exam
    {
        public static string LessonName = "Домашняя работа No 9. Промежуточная аттестация";

        /// <summary>
        /// Рекурсивный вывод чисел от N до 1
        /// </summary>
        /// <param name="number"> Начало отсчета</param>
        public static void PrintFromNToOne(int number)
        {
            if (number == 0)
            {
                return;
            }

            else
            {
                Console.Write(number + " ");
                PrintFromNToOne(number - 1);
            }
        }
        /// <summary>
        /// Сумма чисел от n до m
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int SumFromNtoM(int n, int m)
        {

            if (n + m == 0)
            {
                Console.WriteLine("Сумма = 0");
                return 0;
            }

            if (n == m)
            {
                return n;
            }



            return n + SumFromNtoM(n+1, m);
        }

        public static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
        }

        public static void RunHomework()
        {
            // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
            // Выполнить с помощью рекурсии.
            Console.WriteLine("Числа в промежутке от N до 1");
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"N = {n} -> ");
            PrintFromNToOne(n);
            Console.WriteLine();

            // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            Console.WriteLine("Сумма натуральных элементов в промежутке от M до N");
            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"Сумма чисел от {first} до {second} -> ");
            Console.Write(SumFromNtoM(first, second));
            Console.WriteLine();

            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            Console.WriteLine("Функция Аккермана с помощью рекурсии");

            Console.Write("Первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Второе число: ");
            int b = int.Parse(Console.ReadLine());

            int result = Ackermann(a, b);
            Console.WriteLine("Ackermann({0}, {1}) = {2}", a, b, result);
        }
    }
}
