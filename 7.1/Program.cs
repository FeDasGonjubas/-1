// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Recurse(int min, int max)
{
    if (min + 1 < max)
    {
        Console.Write($"{min + 1} ");
        Recurse(min + 1, max);
    }
}

Console.WriteLine($"Введите такие натуральные числа M и N, чтобы M < N:");
Console.Write("M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("N: ");
int N = int.Parse(Console.ReadLine());
Recurse(M, N);