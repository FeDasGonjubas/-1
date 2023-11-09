// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReverseArray(int[,] mtrx)
{
    int[,] reversedMtrx = new int[mtrx.GetLength(1), mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        reversedMtrx[j,i] = mtrx[i, j];
    }
    return reversedMtrx;
}

int[,] array = GenDoubleArray(3, 4, -10, 10);
Console.WriteLine("Матрица:");
PrintDoubleArray(array);
Console.WriteLine("Перевернутая матрица:");
PrintDoubleArray(ReverseArray(array));