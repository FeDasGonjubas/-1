﻿// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7 - ");
int N = int.Parse(Console.ReadLine());
if (N == 6 || N == 7)
{
    Console.WriteLine("это выходной день");
}
else
{
   Console.WriteLine("это рабочий день"); 
}