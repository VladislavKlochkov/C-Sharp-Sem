// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int digit = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

bool res = Weekend(digit);
string resStr = res ? "День является выходным" : "День не является выходным";

if (digit > 0 && digit < 8)
{
    Console.WriteLine($"{digit} -> {resStr}");
}
else Console.WriteLine("Введённое вами число не отвечает условию");