// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void array(int A)
{
    double a = 0;
    for (int i = 1; i <= A; i++)
    {
        a = Math.Pow(i, 3);
        Console.WriteLine(a);
    }
}

array(Prompt("Введите число: "));
