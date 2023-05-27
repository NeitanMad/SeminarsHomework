using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsHomework
{
    public class Homework3
    {
        public static void Homework()
        {
            // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

            Console.Write("Введите пятизначное число: ");
            int number = int.Parse(Console.ReadLine());

            string numberToString = number.ToString();

            for (int i = 0; i < numberToString.Length / 2; ++i)
            {
                if (numberToString[i] != numberToString[numberToString.Length - 1 - i])
                {
                    Console.WriteLine("Не палиндром");
                    break;
                }
                else
                {
                    Console.WriteLine("Палиндром");
                    break;
                }
            }
            Console.WriteLine();

            // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

            Console.WriteLine("Введите координаты первой точки (x1 y1 z1):");
            string input1 = Console.ReadLine();
            string[] coords1 = input1.Split(' ');
            double x1 = double.Parse(coords1[0]);
            double y1 = double.Parse(coords1[1]);
            double z1 = double.Parse(coords1[2]);

            Console.WriteLine("Введите координаты второй точки (x2 y2 z2):");
            string input2 = Console.ReadLine();
            string[] coords2 = input2.Split(' ');
            double x2 = double.Parse(coords2[0]);
            double y2 = double.Parse(coords2[1]);
            double z2 = double.Parse(coords2[2]);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance:f2}.");
            Console.WriteLine();

            // Задача 23 Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица кубов чисел от 1 до N:");
            Console.WriteLine("----------------------");

            for (int i = 1; i <= N; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"{i}:\t{cube}");
            }

            Console.WriteLine("----------------------");
        }
    }
}
