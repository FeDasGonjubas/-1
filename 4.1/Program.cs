// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.

string inputData()
{
    Console.Write("Введите число или q,чтобы закончить: ");
    string msg = Console.ReadLine();
    return msg;
}

bool getAnswer(string msg)
{
    int sum = 0;
    bool answer = false;
    if (msg == "q")
    {
        answer = true;
    }
    else
    {
        int number = int.Parse(msg);
        for (int i = 0; i < msg.Length; i++)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        if (sum % 2 == 0)
        {
            answer = true;
        }
    }
    return answer;
}

string message = "";
bool answer = false;
while (answer == false)
{
    message = inputData();
    answer = getAnswer(message);
}