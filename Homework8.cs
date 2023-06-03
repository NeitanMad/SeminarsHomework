namespace SeminarsHomework
{
    public class Homework8
    {
        public static string LessonName = "Домашняя работа No 8";

        /// <summary>
        /// Обход массива по спирали
        /// </summary>
        /// <param name="arr"></param>
        public static int[,] Spiral(int height, int widht)
        {
            int[,] array = new int[height, widht];
            int value = 1;
            int rowStart = 0, rowEnd = array.GetLength(0) - 1, colStart = 0, colEnd = array.GetLength(1) - 1;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                // заполнение верхней строки
                for (int i = colStart; i <= colEnd; i++)
                {
                    array[rowStart, i] = value;
                    value++;
                }
                rowStart++;

                // заполнение правого столбца
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    array[i, colEnd] = value;
                    value++;
                }
                colEnd--;

                // заполнение нижней строки
                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        array[rowEnd, i] = value;
                        value++;
                    }
                    rowEnd--;
                }

                // заполнение левого столбца
                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        array[i, colStart] = value;
                        value++;
                    }
                    colStart++;
                }
            }
            return array;
        }

        /// <summary>
        /// Создать массив определенного размера
        /// </summary>
        /// <param name="height">Количество строк</param>
        /// <param name="widht">Количество столбцов</param>
        /// <returns></returns>
        public static int[,] CreateArray(int height, int widht)
        {
            Random random = new Random();

            int[,] array = new int[height, widht];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < widht; j++)
                {
                    array[i, j] = random.Next(10);
                }
            }

            return array;
        }

        /// <summary>
        /// Создать прямоугольный массив
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[,] CreateArray(int size)
        {
            Random random = new Random();

            int[,] array = new int[size, size];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                }
            }

            return array;
        }
        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Проверяет содержит ли трехмерный массив число
        /// </summary>
        /// <param name="array"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        static bool Contains(int[,,] array, int num)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] == num)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static void RunHomework()
        {
            // Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            Console.WriteLine("Дан массив:" + "\n");
            int[,] array = CreateArray(3, 3);

            PrintArray(array);
            //

            // Сортировка каждой строки по убыванию
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i, k])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("\n" + "Отсортированный массив:" + "\n");
            PrintArray(array);
            Console.WriteLine();


            // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            Console.WriteLine("Дан массив:" + "\n");
            int[,] arr = CreateArray(4);
            PrintArray(arr);
            int[] arraySum = new int[arr.GetLength(0)]; // средние значения храним тут

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = 0;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    temp += arr[i, j];
                }

                arraySum[i] += temp;
            }

            Console.WriteLine($"Минимальная сумма элементов -> {arraySum.Min()} " +
                $"в строке: {Array.IndexOf(arraySum, arraySum.Min()) + 1}");
            Console.WriteLine();

            // Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
            Console.WriteLine("Задайте размер первой матрицы: ");
            int[,] firstMatrix = CreateArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Задайте размер второй матрицы: ");
            int[,] secondMatrix = CreateArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Первая матрица");
            PrintArray(firstMatrix);
            Console.WriteLine("Второая матрица");
            PrintArray(secondMatrix);

            int rows1 = firstMatrix.GetLength(0);
            int cols1 = firstMatrix.GetLength(1);
            int rows2 = secondMatrix.GetLength(0);
            int cols2 = secondMatrix.GetLength(1);

            int[,] resultMatrix = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            Console.WriteLine("Результирующая матрица:");
            PrintArray(resultMatrix);
            Console.WriteLine();

            // Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

            Random rnd = new Random();

            Console.WriteLine("Введите размер трехмерного массива:");
            int[,,] ints = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    for (int k = 0; k < ints.GetLength(2); k++)
                    {
                        while (ints[i, j, k] == 0)
                        {
                            int temp = rnd.Next(10, 100);

                            if (Contains(ints, temp) == false)
                            {
                                ints[i, j, k] += temp;
                            }
                        }

                    }
                }
            }
            Console.WriteLine();

            // Для большего понимания представил трехмерный массив ввиде книги,
            //где первое измерение это книга, второе страница, а третье это строка на странице
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                Console.WriteLine($"Книга: {i + 1}");

                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"  Страница: {j + 1}");

                    for (int k = 0; k < ints.GetLength(2); k++)
                    {
                        Console.WriteLine("   Строка: " + (k + 1) + " элемент: " + ints[i, j, k] + " (" + i + j + k + ")");
                    }
                }
            }
            Console.WriteLine();

            //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.

            Console.WriteLine("Введите рахмер двумерного массивва: ");

            Console.Write("Количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Количество столбцов: ");
            int coloums = int.Parse(Console.ReadLine());

            int[,] spiralArray = Spiral(rows, coloums);
            Console.WriteLine();

            PrintArray(spiralArray);


        }
    }
}
