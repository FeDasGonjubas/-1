// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] GenerateFibArray(int N)
{
    int[] ArrayF = new int[N];
    ArrayF[1] = 1;
    for (int i = 2; i < N; i++)
    {
        ArrayF[i] = ArrayF[i - 1] + ArrayF[i - 2];
    }
    return ArrayF;
}

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int[] FibArray = GenerateFibArray(Number);
PrintArray(FibArray);