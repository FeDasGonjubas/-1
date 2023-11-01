// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
double min = 0;
double max = 0;
Console.WriteLine("Массив вещественных чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 10;
    if (i == 0)
    {
        min = array[0];
        max = array[0];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
    Console.WriteLine(array[i]);
}

Console.WriteLine($"Наибольший элемент массива: {max}");
Console.WriteLine($"Наименьший элемент массива: {min}");
Console.WriteLine($"Разница между наибольшим и наименьшим: {max - min}");