// 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomnum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 --> {randomnum}");

int DeleteSecond(int num)
{
    int firstDigit = num / 100; // 4
    int thirdDigit = num % 10; // 6
    int res = firstDigit * 10 + thirdDigit;
    return res;
}

int res = DeleteSecond(randomnum);

Console.WriteLine($"Новое число {res}");