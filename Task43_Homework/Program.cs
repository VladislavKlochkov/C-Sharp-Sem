// Задача 43: 
// 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметры первой прямой");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметры второй прямой");
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double PointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double PointY(double b1, double k1, double b2, double k2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}

if (k1 != k2)
{
    double resX = Math.Round(PointX(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
    double resY = Math.Round(PointY(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
    Console.WriteLine($"Прямые пересекаются в точке ({resX},{resY})");
}
else Console.WriteLine("Прямые параллельны");