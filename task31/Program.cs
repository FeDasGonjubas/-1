// задача 31:
// Задайте массив из 12 элементов, заполненный случайными
//  числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] SumArrayElements(int[] arr)
{
    int[] Sum = new int[2];
    foreach (int item in arr)
    {
        if (item < 0)
        {
            Sum[0] = Sum[0] + item;
        }
        else
        {
            Sum[1] = Sum[1] + item;
        }
    }
    return Sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.WriteLine($"{arr[i]}]");
        }
    }
}

void PrintResult(int[] arr)
{
    Console.WriteLine($"Сумма отрицательных элементов массива: {arr[0]}, сумма положительных: {arr[1]}");
}

int[] Array = GetArray(12);
int[] Result = SumArrayElements(Array);
PrintArray(Array);
PrintResult(Result);
