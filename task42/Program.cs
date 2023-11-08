// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] ConvertNumber(int number)
{
    int temp = number;
    int count = 0;
    while (temp != 0)
    {
        temp = temp / 2;
        count++;
    }
    Console.WriteLine(count);
    int[] array = new int[count];
    for (int i = count - 1; i >= 0; i = i - 1)
    {
        array[i] = (number % 2);
        number = number / 2;
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] Array = ConvertNumber(number);
PrintArray(Array);
