// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

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

void PrintDoubleArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

void PrintArrayRecurse(int[,] arr, int i, int j)
{
    if (j < 0)
    {
        i = i - 1;
        j = arr.GetLength(1) - 1;
    }
    if (i >= 0 && j >= 0)
    {
        Console.Write($"{arr[i, j]} ");
        PrintArrayRecurse(arr, i, j - 1);
    }
}

int[] box = {3, 3};
int[,] DoubleArray = GenDoubleArray(box[0], box[1], 0, 10);
Console.WriteLine("Случайный массив:");
PrintDoubleArray(DoubleArray);
Console.WriteLine("Тот же массив, но выведенный рекурсией последовательно с конца:");
PrintArrayRecurse(DoubleArray, box[0] - 1, box[1] - 1);