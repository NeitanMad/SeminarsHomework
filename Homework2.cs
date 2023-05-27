using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsHomework
{
    public class Homework2
    {
        public static void Homework()
        {

            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вторая цифра числа {number} -> {number.ToString()[1]}");
            Console.WriteLine();

            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            if (num.ToString().Length >= 3)
            {
                Console.WriteLine($"Третья цифра числа {num} -> {num.ToString()[2]}");
            }
            else
            {
                Console.WriteLine($"{num} -> число двузначное!");
            }
            Console.WriteLine();

            // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            Console.Write("Введите число от 1 до 7: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 6:
                    Console.WriteLine("Выходной");
                    break;
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Рабочий день");
                    break;
            }
            Console.WriteLine();
        }
    }
}
