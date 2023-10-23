// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] Prompt(string message1, string message2)
{
    int[] array = new int[2];
    Console.Write(message1);
    array[0] = int.Parse(Console.ReadLine());
    Console.Write(message2);
    array[1] = int.Parse(Console.ReadLine());
    return array;
}

void distance(int[] A, int[] B)
{
    double length = Math.Pow((Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2)), 0.5);
    Console.WriteLine("Расстояние между точками: " + length);
}

int[] dotA = Prompt("Введите координату X точки A - ", "Введите координату Y точки A - ");
int[] dotB = Prompt("Введите координату X точки B - ", "Введите координату Y точки B - ");
distance(dotA, dotB);
