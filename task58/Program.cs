// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] MultiplicateMatrixes(int[,] arr1, int[,] arr2)
{
    int[,] mtrx = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int m = 0; m < arr1.GetLength(1); m++)
            {
                mtrx[i, j] = mtrx[i, j] + arr1[i, m] * arr2[m, j];
            } 
        }
    }
    return mtrx;
}

int[,] array1 = GenDoubleArray(4, 2, 1, 5); // (кол-тво строк, кол-тво столбцов, минимум, максимум)
int[,] array2 = GenDoubleArray(2, 3, 1, 5);

Console.WriteLine("Первая матрица:");
PrintDoubleArray(array1);
Console.WriteLine("Вторая матрица:");
PrintDoubleArray(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Данные матрицы невозможно перемножить!");
}
else
{
    int[,] ResultArray = MultiplicateMatrixes(array1, array2);
    Console.WriteLine("Результат перемножения матриц:");
    PrintDoubleArray(ResultArray);
}