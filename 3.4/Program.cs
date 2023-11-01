// Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива,
// младший – на последнем. Размер массива должен быть равен количеству цифр.

int number = new Random().Next(1, 100001);
Console.WriteLine($"Случайное число: {number}");
int numberDigit = 0;
int temp = number;
int tenTemp = 1;

while (temp != 0)
{
    numberDigit++;
    temp = temp / 10;
    tenTemp = tenTemp * 10;
}
tenTemp = tenTemp / 10;

int[] array = new int[numberDigit];
for (int i = 0; i < numberDigit; i++)
{
    array[i] = number / tenTemp;
    number = number % tenTemp;
    tenTemp = tenTemp / 10;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}