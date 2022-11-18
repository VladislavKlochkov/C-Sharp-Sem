
// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index, 4} || {index * index, 4}"); // 4 - отступ;
        index++;
    }

}

if (number > 0) Square(number);
else Console.WriteLine("Введите число больше нуля");