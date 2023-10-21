// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (number1 < number2)
{
    max = number2;
    number2 = number1;
}
Console.Write(max);
Console.Write(" больше, чем ");
Console.WriteLine(number2);
// Console.WriteLine(number1);
// Console.WriteLine(number2);