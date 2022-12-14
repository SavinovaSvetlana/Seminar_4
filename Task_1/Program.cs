// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int namber = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе = {GetCount(namber)}");

int GetCount(int namTemp)
{
    int count = 0;
    while (namTemp > 0)
    {
        namTemp /= 10;
        count++;
    }
    return count;
}