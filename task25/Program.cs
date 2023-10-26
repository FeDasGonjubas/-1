// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] Prompt(string msg1, string msg2)
{
    int[] arr = new int[2];
    Console.Write(msg1);
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write(msg2);
    arr[1] = int.Parse(Console.ReadLine());
    return arr;
}

int[] numAndDgr = Prompt("Введите число: ", "Теперь введите степень: ");
double numInDgr = Math.Pow(numAndDgr[0], numAndDgr[1]);

Console.Write("Число, возведенное в степень: " + numInDgr);
