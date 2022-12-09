// Задача 67: 
// 1. Напишите программу, которая будет принимать на вход число и
// 2. возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitals(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigitals(num / 10);  
}

int sumDigitals = SumDigitals(Math.Abs(number));
Console.WriteLine($"{sumDigitals}");