// Задача 6: Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} - является чётным");
}
else Console.WriteLine($"Число {number} - не является чётным");