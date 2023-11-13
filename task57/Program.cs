// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[] GetArray(int lngth, int min, int max)
{
    int[] array = new int[lngth];
    for (int i = 0; i < lngth; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Одномерный массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr)
{
    int temp = 0;
    int min = arr[0];
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        min = arr[i];
        minIndex = i;
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < min)
            {
                min = arr[j];
                minIndex = j;
            }
        }
        temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
    return arr;
}

void CountAndPrintEl(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        count++;
        if (arr[i] != arr[i - 1])
        {
            PrintResult(arr[i - 1], count);
            if (i == arr.Length - 1)
            {
                PrintResult(arr[i], 1);
            }
            count = 0;
        }
        else if (i == arr.Length - 1)
        {
            count++;
            PrintResult(arr[i], count);
        }
    }
}

void PrintResult(int number, int amount)
{
    if (amount % 10 == 2 || amount % 10 == 3 || amount % 10 == 4)
    {
        Console.WriteLine($"{number} встречается {amount} раза");
    }
    else
    {
        Console.WriteLine($"{number} встречается {amount} раз");
    }
}

int[] Array = GetArray(10, 1, 5);
PrintArray(Array);
Console.WriteLine();
PrintArray(SortArray(Array));
CountAndPrintEl(SortArray(Array));
