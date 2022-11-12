// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.Write($"{a} ");
    }
    a++;
}