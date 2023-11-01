// Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
Console.WriteLine("Массив чисел:");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    if (array[i] % 2 == 0)
    {
        count++;
    }
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива: {count}");