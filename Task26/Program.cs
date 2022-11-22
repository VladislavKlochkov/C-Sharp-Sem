﻿// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Quantity(int num)
{
    int quantity = 0;
    while (num != 0)
    {
        num = num / 10;
        quantity++;
    }
    return quantity == 0 ? 1 : quantity;
}

int res = Quantity(number);
Console.WriteLine($"Количество цифр в числе {number} -> {res}");