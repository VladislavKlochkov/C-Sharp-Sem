// Задача 65: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите два числа:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumberMToN(m, n);

void NaturalNumberMToN(int m, int n)
{
    if (m == n) Console.Write($"{m} ");
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumberMToN(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumberMToN(m + 1, n);
    }
}