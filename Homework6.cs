namespace SeminarsHomework
{
    public class Homework6
    {
        public static string LessonName = "Домашняя работа No 6";

        public static void RunHomework()
        {
            // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            Console.Write("Сколько чисел хотите ввести: ");
            int index = 1;
            int result = 0;
            int[] array = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{index + i} число: ");
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Четных -> ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result++;
                }
            }
            Console.Write(result);
            Console.WriteLine();

            /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */
            Console.WriteLine("Введите значения k1, b1, k2 и b2 через пробел:");
            string[] input = Console.ReadLine().Split(' ');

            double k1 = double.Parse(input[0]);
            double b1 = double.Parse(input[1]);
            double k2 = double.Parse(input[2]);
            double b2 = double.Parse(input[3]);

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);
            Console.ReadLine();

        }
    }
}
