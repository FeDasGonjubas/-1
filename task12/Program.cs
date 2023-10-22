// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine(number1 + ", " + number2);
int i = number1 % number2;
if (i == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Не кратно, остаток - " + i);
}