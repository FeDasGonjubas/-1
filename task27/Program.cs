// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string prompt(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine();
    return number;
}

int calcSum(string num)
{
    int sum = 0;
    for (int i = 0; i <= num.Length - 1; i++)
    {
        sum = sum + (int)Char.GetNumericValue(num[i]);
    }
    return sum;
}

Console.WriteLine("Сумма цифр введенного числа: " + calcSum(prompt("Введите число: ")));
