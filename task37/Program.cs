// Задача 37: Задайте одномерный массив, заполненный случайнымичислами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

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

void CountSumOfEl(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

int[] Array = GetRandomArray(4, -10, 10);
PrintArray(Array);
CountSumOfEl(Array);