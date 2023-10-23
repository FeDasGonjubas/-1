// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void diapazon(int A)
{
    if (A == 1)
    {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if (A == 2)
    {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if (A == 3)
    {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if (A == 4)
    {
        Console.WriteLine("X > 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Нет такого квадранта");
    }
}

int quart = Prompt("Введите номер квадранта - ");
diapazon(quart);

