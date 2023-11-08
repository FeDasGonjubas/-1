// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с
// сторонами такой длины.

int[] InputSideLength()
{
    int[] arr = new int[3];
    Console.Write("Введите первое значение: ");
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите второе значение: ");
    arr[1] = int.Parse(Console.ReadLine());
    Console.Write("Введите третье значение: ");
    arr[2] = int.Parse(Console.ReadLine());
    return arr;
}

void CheckSides(int[] arr)
{
    int perimetr = arr[0] + arr[1] + arr[2];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] * 2 < perimetr)
        {
            count++;
        }
    }
    if (count == 3)
    {
        Console.WriteLine("Треугольник с такими сторонами возможен");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами НЕвозможен");
    }
}

int[] Sides = InputSideLength();
CheckSides(Sides);
