// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
Console.Write("A: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
Console.Write("B: ");
int second = Convert.ToInt32(Console.ReadLine());

int PowersOfNumber(int num, int powers)
{
    int res = num;
    for (int i = 2; i <= powers; i++)
    {
        res = res * num;
    }
    return res;
}

if (second > 0)
{
    int result = PowersOfNumber(first, second);
    Console.WriteLine($"{first} в степени {second} -> {result}");
}
else Console.WriteLine("Второе число ненатуральное, пожалуйста, введите число больше 0");