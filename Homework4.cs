namespace SeminarsHomework
{
    public class Homework4
    {
        public static void Homework()
        {
            //// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных

            //Console.Write("Укажите длину массива: ");
            //int length = int.Parse(Console.ReadLine());

            //int[] array = new int[length];

            //Random random = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(100, 1000);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        Console.Write($"{array[i]}, ");
            //    }
            //}

            //// TODO
            ///

            //// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            //Console.Write("Введите число A: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Введите число B: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 0; i < secondNumber; i++)
            //{
            //    result *= firstNumber;
            //}

            //Console.WriteLine("Число A в степени B -> " + result);
            //Console.WriteLine();

            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //Console.Write("Введите число: ");
            //string input = Console.ReadLine();

            //int[] arrayNumbers = new int[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    arrayNumbers[i] = Convert.ToInt32(input[i].ToString()); // Приведение к целочисленному значению
            //}

            //Console.WriteLine("Сумма цифр -> " + arrayNumbers.Sum());
            //Console.WriteLine();

            // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            Console.Write("Введите длину массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(99);
            }

            Console.WriteLine("Заполнение массива случайными числами..");

            Thread.Sleep(2000); // Ожидаем 2 сек, типа происходит магия.))

            Console.WriteLine("Массив заполнен.");

            Console.Write("Полученый массив -> [" );
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i == array.Length - 1)
                    break;
                else
                    Console.Write(", ");
            }
            Console.Write("]");

        }
    }
}
