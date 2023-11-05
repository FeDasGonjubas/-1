// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetRandomDoubleArray(int m, int n, int min, int max, int digit)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round((min + (new Random().NextDouble()) * (max - min)), digit);
        }
    }
    return matrix;
}

void PrintDoubleArray(double[,] mtrx)
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

double[,] Matrix = GetRandomDoubleArray(4, 4, 0, 10, 1);
PrintDoubleArray(Matrix);
