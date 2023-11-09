// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void CountAvrgAndPrint(int[,] mtrx)
{
    double[] Average = new double[mtrx.GetLength(1)];
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            Average[j] = Average[j] + mtrx[i, j];
        }
        Average[j] = Math.Round(Average[j] / mtrx.GetLength(0), 1);
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < Average.Length; i++)
    {
        if (i != Average.Length - 1)
        {
            Console.Write($"{Average[i]}; ");
        }
        else
        {
            Console.Write($"{Average[i]}.");
        }
    }
}

int[,] Matrix = GetRandomArray(3, 4, 0, 10);
PrintArray(Matrix);
CountAvrgAndPrint(Matrix);