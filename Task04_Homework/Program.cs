// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа");

int max = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (max < a)
{
    max = a;
}
if (max < b)
{
    max = b;
}

Console.WriteLine($"Максимальное из введенных вами чисел = {max}");