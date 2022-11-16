// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int num1 = num % 100;
    int num3 = num % 10;
    int num2 = (num1 - num3) / 10;
    return num2;
}

int res = SecondDigit(number);

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {res}");
}
else if (number < -99 && number > -1000)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {-res}");
}
else Console.WriteLine($"Введённое вами число {number} не является трёхзначным");