namespace SeminarsHomework
{
    public class Homework7
    {
        public static string LessonName = "Домашняя работа No 7";

        public static void RunHomework()
        {
            // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

            Console.WriteLine("Задайте размер двумерного массива:");

            Console.Write("Количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Количество столбцов: ");
            int coulmn = int.Parse(Console.ReadLine());

            Random random = new Random();

            double[,] array = new double[rows, coulmn];

            Console.WriteLine("Заполнение случайными эллементами..");
            Thread.Sleep(1000);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    array[i, j] = random.NextDouble();
                }
            }

            Console.WriteLine("Полученный массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            /* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            и возвращает значение этого элемента или же указание, что такого элемента нет. */
            bool answer = true;
            Console.WriteLine("Дан массив:");

            int[,] arr = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = random.Next(51);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            while (answer)
            {
                Console.WriteLine("Укажите элемент, что бы узнать его индекс");
                Console.Write("Элемент: ");

                int find = int.Parse(Console.ReadLine());
                bool flag = false;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arr[i, j] == find)
                        {
                            Console.WriteLine($"Индекс элемента {find} -> {i} , {j}");
                            flag = true;
                            break;
                        }
                    }
                }

                if (flag == false)
                {
                    Console.WriteLine($"Элемент {find} -> не существует!");
                }

                Console.WriteLine("Хотите узнать индекс другого элемента? Y/N");

                string symbol = Console.ReadLine();

                if (symbol.ToLower() == "y")
                {
                    answer = true;
                }
                else answer = false;
            }

            // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            Console.Write("Количество строк: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Количество столбцов: ");
            coulmn = int.Parse(Console.ReadLine());

            int[,] ints = new int[rows, coulmn];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    ints[i, j] = random.Next(11);
                }
            }

            Console.WriteLine("Полученный массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Создаем массив для хранения средних арифметических значений
            double[] averages = new double[coulmn];

            // Находим среднее арифметическое элементов в каждом столбце
            for (int j = 0; j < coulmn; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += ints[i, j];
                }
                averages[j] = (double)sum / rows;
            }

            // Выводим средние арифметические значения на экран
            for (int j = 0; j < coulmn; j++)
            {
                Console.WriteLine("Среднее арифметическое в столбце {0}: {1}", j, averages[j]);
            }
        }
    }
}
