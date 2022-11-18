// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine(Math.Sqrt(25));
// double n = 5.099346678;
// double res = Math.Round(n, 2, MidpointRounding.ToZero);
// Console.WriteLine(res);

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double  Distance(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya));
}


double res = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);