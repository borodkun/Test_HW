using System;

namespace HomeWork_4_Part_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Объявление динамического массива "V"
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

            //Вывод исходной матрицы "V"
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

            //Объявление динамического массива "O"
            Console.WriteLine("Введите число строк матрицы ");
            int sizem1 = int.Parse(Console.ReadLine()); Console.WriteLine("Введите число столбцов матрицы ");
            int sizem2 = int.Parse(Console.ReadLine()); int[,] o = new int[sizem1, sizem2];

            //Заполнение матрицы случайными числами
            Random rand = new Random();
            for (int i = 0; i < o.GetLength(0); i++)
                for (int j = 0; j < o.GetLength(1); j++)
                {
                    o[i, j] = rand.Next(1, 10); ;
                }
            Console.WriteLine("\n");

            //Вывод исходной матрицы "O"
            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < o.GetLength(0); i++)
            {
                for (int j = 0; j < o.GetLength(1); j++)
                {
                    Console.Write(o[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine();

            //Сложение двух матриц "V" и "О"
            for (int i = 0; i < v.GetLength(0); i++)
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    v[i, j] = v[i, j] + o[i, j];
                }
            Console.WriteLine("\n");

            //Вывод новой матрицы
            Console.WriteLine($"Сумма двух матриц 'V' 'O'");
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