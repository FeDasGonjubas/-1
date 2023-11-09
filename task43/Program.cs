// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

int[] GetKoeff(string msg1, string msg2)
{
    int[] arr = new int[2];
    Console.Write(msg1);
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write(msg2);
    arr[1] = int.Parse(Console.ReadLine());
    return arr;
}

void PrintCoord(int[] arr1, int[] arr2)
{
    double X = (arr2[1] - arr1[1]) / (arr1[0] - arr2[0]);
    double Y = arr1[0] * X + arr1[1];
    Console.WriteLine($"Координаты точки пересечения прямых (X; Y): ({X}; {Y})");
}

int[] FirstKoef = GetKoeff
(
    "Введите k1 для функции y = k1 * x + b1: ",
    "Введите b1 для функции y = k1 * x + b1: "
);
int[] SecondKoef = GetKoeff
(
    "Введите k2 для функции y = k2 * x + b2: ",
    "Введите b2 для функции y = k2 * x + b2: "
);

PrintCoord(FirstKoef, SecondKoef);




