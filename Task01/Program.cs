// 1. Напишите программу, которая 
// 1. на вход принимает два числа
// 2. и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите два целых числа");

int a, b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else Console.WriteLine("Нет");


