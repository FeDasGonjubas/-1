// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
Console.WriteLine("Массив чисел:");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
Console.WriteLine($"Количество элементов массива в отрезке [20; 90]: {count}");

