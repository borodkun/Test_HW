using System;

namespace Matrix_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление динамического массива
            Console.WriteLine("Введите число строк матрицы ");
            int size1 = int.Parse(Console.ReadLine()); Console.WriteLine("Введите число столбцов матрицы ");
            int size2 = int.Parse(Console.ReadLine()); int[,] v = new int[size1, size2];

            //Заполнение матрицы случайными числами
            Random rnd = new Random();
            for (int i = 0; i < v.GetLength(0); i++)
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    v[i, j] = rnd.Next(1, 10); ;
                }
            Console.WriteLine("\n");

            //Вывод исходной матрицы
            Console.WriteLine("Исходная матрица");
                for (int i = 0; i < v.GetLength(0); i++)
                {
                    for (int j = 0; j < v.GetLength(1); j++)
                    {
                        Console.Write(v[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }

                Console.WriteLine();

            //Умножение всех элементов матрицы на число
            Console.WriteLine("Введите число на которое умножить");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            //Умножение всех элементов матрицы на число
            for (int i = 0; i < v.GetLength(0); i++)
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    v[i, j] = v[i, j] * number;
                }
            Console.WriteLine("\n");

            //Вывод новой матрицы
            Console.WriteLine($"Умножение матрицы на {number}");
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    Console.Write(v[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}