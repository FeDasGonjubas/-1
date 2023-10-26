// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int prompt(string msg)
{
    Console.Write(msg);
    int arrLen = int.Parse(Console.ReadLine());
    return arrLen;
}

int[] buildArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i <= n - 1; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void printArray(int[] ar)
{
    for (int i = 0; i <= ar.Length - 1; i++)
    Console.WriteLine(ar[i]);
}
int[] array = buildArray(prompt("Введите длину массива: "));
printArray(array);