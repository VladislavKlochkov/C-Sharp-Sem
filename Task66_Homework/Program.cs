// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumberMtoN(int m, int n)
{
    if (m < n) return m + SumNaturalNumberMtoN(m + 1, n);
    else if (m > n) return m + SumNaturalNumberMtoN(m - 1, n);
    else return n;
}

if (m > 0 && n > 0)
{
    int res = SumNaturalNumberMtoN(m, n);
    Console.WriteLine($"{res}");
}
else Console.WriteLine($"Введите числа больше нуля!");