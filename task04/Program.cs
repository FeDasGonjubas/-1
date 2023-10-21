// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.Write("Наибольшее число - ");
Console.WriteLine(max);


// Console.WriteLine(number1);
// Console.WriteLine(number2);
// Console.WriteLine(number3);