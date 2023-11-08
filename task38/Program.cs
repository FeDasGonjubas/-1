// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GetRandomArray(int length, int min, int max, int digit)
{
    double[] matrix = new double[length];
    for (int i = 0; i < length; i++)
    {
        matrix[i] = Math.Round((min + (new Random().NextDouble()) * (max - min)), digit);
    }
    return matrix;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");  
    }
    Console.WriteLine();
}

void Delta(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"Разница между наибольшим и наименьшим элементами: {max - min}");
}

double[] Array = GetRandomArray(5, -10, 10, 1);
PrintArray(Array);
Delta(Array);