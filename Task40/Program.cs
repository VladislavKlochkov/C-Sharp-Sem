// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны:");
int number3 = Convert.ToInt32(Console.ReadLine());

bool ExistTriangle(int n1, int n2, int n3)
{
    return n1 < n2 + n3 && n2 < n1 + n2 && n3 < n1 + n3;
}

if (number1 > 0 && number2 > 0 && number3 > 0)
{
    bool res = ExistTriangle(number1, number2, number3);
    string resStr = res ? "Такой треугольник существует" : "Такой треугольник не существует";
    Console.WriteLine($"{resStr}");
}
else Console.WriteLine("Введите значения больше нуля");