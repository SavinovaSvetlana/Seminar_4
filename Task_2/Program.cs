// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел = {GetProdNam(N)}");

int GetProdNam(int namber)
{
    int prod = 1;
    while (namber > 0)
    {
        prod *= namber;
        namber--;
    }
    return prod;
}
