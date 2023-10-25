// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
string prompt(string message)
{
    Console.Write(message);
    string n = Console.ReadLine();
    return n;
}

bool NumberCheck(string m)
{
    bool palindrom = false;
    for (int i = 0; i < m.Length / 2; i++)
    {
        if (m[i] == m[m.Length - i - 1])
        {
            palindrom = true;
        }
        else
        {
            palindrom = false;
            break;
        }
    }
    return palindrom;
}

void Answer(bool q)
{
    if (q == true)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Увы, это не палиндром");
    }
}

Answer(NumberCheck(prompt("Введите число, чтобы проверить палиндром ли оно: ")));
