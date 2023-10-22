﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1,100000);
Console.WriteLine("Сгенерированное число - " + number);
if (number / 100 == 0)
{
    Console.WriteLine("У данного числа нет третьей цифры");
}
else
{
    while (number / 1000 != 0)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра сгенерированного числа - " + number % 10);
}

 
