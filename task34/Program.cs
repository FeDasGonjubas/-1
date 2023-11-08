// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int Length, int min, int max)
{
    int[] Array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Array[i] = new Random().Next(min, max + 1);
    }
    return Array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

void CountEvenInArray(int[] arr)
{
    int EvenCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            EvenCounter++;
        }
    }
    Console.WriteLine($"Количество четных элементов в массиве: {EvenCounter}");
}

int[] Array = GetRandomArray(10, 1, 999);
PrintArray(Array);
CountEvenInArray(Array);