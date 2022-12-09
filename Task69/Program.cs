// Задача 69: 
// 1. Напишите программу, которая на вход принимает два числа A и B, и
// 2. возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите два числа:");
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowersOfNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 * PowersOfNumber(num1, num2 - 1);
}

int res = PowersOfNumber(a, b);
Console.WriteLine(res);