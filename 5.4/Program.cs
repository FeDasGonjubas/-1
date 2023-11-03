// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
//  Под удалением понимается создание нового двумерного массива без строки и столбца

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

int[] FindLessElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] minPosition = {0, 0};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minPosition[0] = i;
                minPosition[1] = j;
            }
        }
    }
    Console.WriteLine($"Наим элемент: {min}. Его координаты: [{minPosition[0]}, {minPosition[1]}]");
    return minPosition;
}

int[,] DeleteStringAndColumn(int[,] matrix, int[] position)
{
    int[,] NewMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        if (i < position[0])
        {
            m = i;
        }
        else
        {
            m = i +1;
        }
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            if (j < position[1])
            {
                n = j;
            }
            else
            {
                n = j + 1;
            }
            NewMatrix[i, j] = matrix[m, n];
        }
            
    }
    return NewMatrix;
}

int[] box = {5, 5};
int[,] DoubleArray = GenDoubleArray(box[0], box[1], -10, 10);
PrintDoubleArray(DoubleArray);
Console.WriteLine();
int[] MinPosition = FindLessElement(DoubleArray);
Console.WriteLine();
int[,] NewDoubleArray = DeleteStringAndColumn(DoubleArray, MinPosition);
PrintDoubleArray(NewDoubleArray);
