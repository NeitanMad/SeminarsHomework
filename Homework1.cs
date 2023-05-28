namespace SeminarsHomework
{
    public class Homework1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================ДЗ 1======================");
            Console.WriteLine();
            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.Write("Введите первое число: ");
            int firstNuber = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNuber > secondNumber)
            {
                Console.WriteLine($"Число {firstNuber} больше числа {secondNumber}");
            }
            else if (firstNuber < secondNumber)
            {
                Console.WriteLine($"Число {secondNumber} больше числа {firstNuber}");
            }
            else
            {
                Console.WriteLine("Числа равны!");
            }

            Console.WriteLine();

            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            Console.WriteLine("Введите три числа");
            int[] nubers = new int[3];
            int count = 0;

            for (int i = 0; i < nubers.Length; i++)
            {
                Console.Write($"{++count} число: ");
                nubers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Максимальное из {count} чисел - {nubers.Max()}");
            Console.WriteLine();

            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.Write("Введите число: ");
            int nuber = int.Parse(Console.ReadLine());

            if (nuber % 2 == 0)
            {
                Console.WriteLine(nuber + " четное");
            }
            else
            {
                Console.WriteLine(nuber + " нечетное");
            }
            Console.WriteLine();

            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            Console.Write("Введите число 'N': ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Чётные числа от 1 до N: ");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 1 < n)
                    {
                        Console.Write($"{i}, ");

                    }


                    else
                        Console.Write($"{i}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("======================ДЗ 2======================");
            Console.WriteLine();

            Homework2.Homework(); // запуск второй домашки

            Console.WriteLine("======================ДЗ 3======================");
            Console.WriteLine();

            Homework3.Homework(); // запуск третьей домашки

            Console.WriteLine("======================ДЗ 4======================");
            Console.WriteLine();

            Homework4.Homework();// запуск четвертой домашки
        }
    }
}