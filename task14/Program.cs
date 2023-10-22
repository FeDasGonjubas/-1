// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 || number % 23 == 0)
{
    Console.WriteLine("Введеное число кратно и 7, и 23");
}
else
{
    Console.WriteLine("Введеное число не кратно одновременно и 7, и 23");
}