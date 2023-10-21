// Задача №5
// Напишите программу, которая н авход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите число натураьное число - ");
int number = int.Parse(Console.ReadLine());
int minusNumber = - number;
while (minusNumber <= number)
{
    Console.WriteLine(minusNumber);
    minusNumber = minusNumber + 1;
}
