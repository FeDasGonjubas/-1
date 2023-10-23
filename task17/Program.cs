// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Quart(int A, int B)
{
    if (A > 0 && B > 0)
    {
        Console.WriteLine("Первый квадрант");
    }
    else if (A < 0 && B > 0)
    {
        Console.WriteLine("Второй квадрант");
    }
    else if (A < 0 && B < 0)
    {
        Console.WriteLine("Третий квадрант");
    }
    else if (A > 0 && B < 0)
    {
        Console.WriteLine("Четвертый квадрант");
    }
    else
    {
        Console.WriteLine("Введена нулевая координата");
    }
}

int X = Prompt("Введите координату X - ");
int Y = Prompt("Введите координату Y - ");
Quart(X, Y);


//Console.WriteLine(X + "   " + Y);
