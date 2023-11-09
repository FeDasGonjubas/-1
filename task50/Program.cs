// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetRandomArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void InputAndCheckPosition(int[,] mtrx)
{
    Console.Write("Введите номер элемента массива: ");
    int position = int.Parse(Console.ReadLine());
    int count = 0;
    bool ElFounded = false;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (position == count)
            {
                Console.WriteLine($"Элемент: {mtrx[i, j]}");
                ElFounded = true;
                count++;
                break;
            }
            else
            {
                count++;
            }

        }
    }
    if (ElFounded == false)
    {
        Console.WriteLine("Такого номера в массиве нет.");
    }
}

int[,] Matrix = GetRandomArray(4, 4, -10, 10);
PrintArray(Matrix);
InputAndCheckPosition(Matrix);