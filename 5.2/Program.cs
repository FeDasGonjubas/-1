// Задача 2: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

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

int[,] ReplaceFirstAndLastStrings(int[,] arr)
{
    int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                array[i, j] = arr[arr.GetLength(0) - 1, j];
            }
            else if (i == arr.GetLength(0) - 1)
            {
                array[i, j] = arr[0, j];
            }
            else
            {
                array[i, j] = arr[i, j];
            }
        }
    }
    return array;
}

int[] box = {5, 5};
int[,] array = GenDoubleArray(box[0], box[1], -10, 10);
PrintDoubleArray(array);
Console.WriteLine();
PrintDoubleArray(ReplaceFirstAndLastStrings(array));

