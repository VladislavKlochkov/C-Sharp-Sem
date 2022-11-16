// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit(int num)
{
    while (num >= 1000 || num <= -1000) num = num / 10;
    return num % 10;
}

int res = thirdDigit(number);

if (number > 99)
{
    Console.WriteLine($"Третья цифра числа {number} -> {res}");
}
else if (number < -99)
{
    Console.WriteLine($"Третья цифра числа {number} -> {-res}");
}
else Console.WriteLine($"В числе {number} третьей цифры нет");