// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов

int[,] GenDoubleArray(int strings, int columns, int min, int max)
{
    int[,] matrix = new int[strings,columns];
    for (int i = 0; i < strings; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
            // Console.Write($"{matrix[i, j]}\t");
        }
        // Console.WriteLine();
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

void FindLessStringSum(int[,] arr)
{
    int MinStringSum = 0;
    int TempStringSum = 0;
    int IndexMinStringSum = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        MinStringSum = MinStringSum + arr[0, k];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            TempStringSum = TempStringSum + arr[i, j];
        }
        if (TempStringSum < MinStringSum)
        {
            MinStringSum = TempStringSum;
            TempStringSum = 0;
            IndexMinStringSum = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов:");
    for (int l = 0; l < arr.GetLength(1); l++)
    {
        Console.Write($"{arr[IndexMinStringSum, l]}\t");
    }
}

int[,] array = GenDoubleArray(3, 5, -10, 10);
PrintDoubleArray(array);
Console.WriteLine();
FindLessStringSum(array);