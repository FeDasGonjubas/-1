// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

string sent(string pointName, string axle)
{
    string sntn = "Введите координату " + axle + " точки " + pointName + " - ";
    return sntn;
}

int[] Prompt(string message1, string message2, string message3)
{
    int[] array = new int[3];
    Console.Write(message1);
    array[0] = int.Parse(Console.ReadLine());
    Console.Write(message2);
    array[1] = int.Parse(Console.ReadLine());
    Console.Write(message3);
    array[2] = int.Parse(Console.ReadLine());
    return array;
}

void distance(int[] A, int[] B)
{
    double length = Math.Pow(
        (Math.Pow((A[0] - B[0]), 2) + 
        Math.Pow((A[1] - B[1]), 2) + 
        Math.Pow((A[2] - B[2]), 2)), 0.5);
    Console.WriteLine("Расстояние между точками: " + length);
}


int[] dotA = Prompt(sent("A","X"), sent("A","Y"), sent("A", "Z"));
int[] dotB = Prompt(sent("B", "X"), sent("B", "Y"), sent("B", "Z"));
distance(dotA, dotB);
