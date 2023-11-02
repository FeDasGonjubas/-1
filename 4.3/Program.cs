// Задача 3: Напишите программу, которая перевернёт одномерный массив
//  (первый элемент станет последним, второй – предпоследним и т.д.)

int[] GetArray(int length, int min, int max)
{
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] RollArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[arr.Length - 1 - i];
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int el in arr)
    {
        Console.Write($"{el}\t");
    }
    Console.WriteLine();
}

int[] array = GetArray(7, -10, 10);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine("Перевернутый массив:");
PrintArray(RollArray(array));
