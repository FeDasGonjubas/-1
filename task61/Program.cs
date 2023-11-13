// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

int[][] GetPascaleArray(int N)
{
    int[][] arr = new int[N][];
    arr[0] = new int[1];
    arr[0][0] = 1;
    for (int i = 1; i < N; i++)
    {
        arr[i] = new int[i + 1];
        for (int j = 0; j <= i ; j++)
        {
            arr[i][0] = 1;
            arr[i][i] = 1;
            if (arr[i][j] == 0)
            {
                arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
            }
            // Console.Write($"{PascaleTriangle[i][j]}\t");
        }
        // Console.WriteLine();
    }
    return arr;
}

void PrintPascaleTriangle(int[][] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int k = 1; k < arr.Length - i; k++)
        {
            Console.Write("\t");
        }
        for (int j = 0; j < arr[i].Length; j++)
        {
            Console.Write($"{arr[i][j]}\t\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в треугольнике Паскаля: ");
int String = int.Parse(Console.ReadLine());
int[][] PascaleTriangle = GetPascaleArray(String);
PrintPascaleTriangle(PascaleTriangle);