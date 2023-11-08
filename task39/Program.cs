// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    return arr;
}


int[] Array = GetRandomArray(5, -10, 10);
PrintArray(Array);
Console.WriteLine("Перевернутый массив:");
PrintArray(ReverseArray(Array));
