using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarsHomework
{
    public class Homework5
    {
        public static string LessonName = "Домашняя работа No 5";

        public static void RunHomework() 
        {
            //// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных

            Console.Write("Укажите длину массива: ");
            int length = int.Parse(Console.ReadLine());

            int countOdd = 0;

            int[] array = new int[length];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
            }
            Console.Write("Массив:");
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countOdd++;
                }

                if (i < array.Length - 1)
                {
                    Console.Write($"{array[i]}, ");
                }
                else
                    Console.Write(array[i]);
            }
            Console.Write($"] четных -> {countOdd}");
            Console.WriteLine();

            // Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.

            Console.Write("Укажите длину массива: ");
            int size = int.Parse(Console.ReadLine());

            int result = 0;

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-99, 100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    result += arr[i];
                }
            }

            Console.Write("Массив:");
            Console.Write("[");

            for (int i = 0; i < arr.Length; i++)
            {

                if (i < arr.Length - 1)
                {
                    Console.Write($"{arr[i]}, ");
                }
                else
                    Console.Write(arr[i]);
            }
            Console.Write($"] сумма -> {result}");
            Console.WriteLine();


            Console.WriteLine();

            // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

            Console.Write("Укажите длину массива: ");
            int arrSize = int.Parse(Console.ReadLine());

            int[] ints= new int[arrSize];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(100);
            }

            Console.Write("Массив:");
            Console.Write("[");

            for (int i = 0; i < ints.Length; i++)
            {

                if (i < ints.Length - 1)
                {
                    Console.Write($"{ints[i]}, ");
                }
                else
                    Console.Write(ints[i]);
            }
            Console.Write($"] разница между маусимальным и минимальным элементом -> {ints.Max() - ints.Min()}");
            Console.WriteLine();

        }
    }
}
