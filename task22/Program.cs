// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// int[] array(int A)
// {
//     int[] arr = new int[0];
//     for (int i = 1; i <= A; i++)
//     {
//         arr[(i - 1)] = i*i;
//     }
//     return arr;
// }

void array(int A)
{
    int a = 0;
    for (int i = 1; i <= A; i++)
    {
        a = i*i;
        Console.WriteLine(a);
    }
}

array(Prompt("Введите число: "));

//Console.WriteLine(Prompt("Введите число: "));

