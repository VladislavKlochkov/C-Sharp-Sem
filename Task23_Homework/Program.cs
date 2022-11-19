// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index,5} | {Math.Pow(index, 3),5}");
        index++;
    }
}

if (number > 0) Cube(number);
else Console.WriteLine("Введите число больше нуля");