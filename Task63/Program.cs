// Задача 63: 
// 1. Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number);

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num-1);
    Console.Write($"{num} ");
}

// void NaturalNumber(int num)
// {
//     if (num == 0)
//     {
//     NaturalNumber(num-1);
//     Console.Write($"{num} ");
//     }
// }