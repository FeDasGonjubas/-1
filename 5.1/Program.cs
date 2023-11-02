// Задача 1: Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenDoubleArray(int a, int b, int min, int max)
{
    int[,] matrix = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
            // Console.Write($"{matrix[i, j]}\t");
        }
        // Console.WriteLine();
    }
    return matrix;
}

void PrintDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

int[] GetPosition(int a, int b)
{
    int[] arr = new int[2];
    Console.Write($"Введите номер строки от 1 до {a}: ");
    arr[0] = int.Parse(Console.ReadLine()) - 1;
    Console.Write($"Введите номер столбца от 1 до {b}: ");
    arr[1] = int.Parse(Console.ReadLine()) - 1;
    return arr;
}

void PrintElement(int[] position, int[,] doubleArr)
{
    if (position[0] < doubleArr.GetLength(0))
    {
        if (position[1] < doubleArr.GetLength(1))
        {
            Console.WriteLine(doubleArr[position[0], position[1]]);
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }
}
int[] box = {5, 5};
int[,] array = GenDoubleArray(box[0], box[1], -10, 10);
PrintDoubleArray(array);
int[] ElementPosition = GetPosition(box[0], box[1]);
PrintElement(ElementPosition, array);
