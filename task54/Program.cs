// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GenDoubleArray(int strings, int columns, int min, int max)
{
    int[,] matrix = new int[strings,columns];
    for (int i = 0; i < strings; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

int[,] SortString(int[,] mtrx, int n)
{
    int temp = 0;
    int max = mtrx[n, 0];
    int maxIndex = 0;
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        max = mtrx[n, i];
        maxIndex = i;
        for (int j = i; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[n, j] > max)
            {
                max = mtrx[n, j];
                maxIndex = j;
            }
        }
        temp = mtrx[n, i];
        mtrx[n, i] = mtrx[n, maxIndex];
        mtrx[n, maxIndex] = temp;
    }
    return mtrx;
}

int[,] SortArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        mtrx = SortString(mtrx, i);
    }
    return mtrx;
}

int[,] array = GenDoubleArray(3, 4, -10, 10);
Console.WriteLine("Матрица:");
PrintDoubleArray(array);
Console.WriteLine("Отсортированная атрица:");
int[,] sortedArray = SortArray(array);
PrintDoubleArray(sortedArray);