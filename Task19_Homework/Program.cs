// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int n)
{
    int n1 = n / 10000;
    int n2 = n % 10000 / 1000;
    int n4 = n % 100 / 10;
    int n5 = n % 10;
    if (n1 == n5 && n2 == n4) return true;
    return false;
}
bool res = Palindrome(number);
string resStr = res ? "является палиндромом" : "не является палиндромом";

if (number > 9999 && number < 100000)
{
    Console.WriteLine($"Число {number} -> {resStr}");
}
else Console.WriteLine($"Введённое вами число не является пятизначным");