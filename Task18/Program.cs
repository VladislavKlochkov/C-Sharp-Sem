// Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string Range(string n)
{
    if (n == "1") return "x > 0, y > 0";
    if (n == "2") return "x < 0, y > 0";
    if (n == "3") return "x < 0, y < 0";
    if (n == "4") return "x > 0, y < 0";
    return "Введены некорректные данные";
}

string result = Range(quarter);
Console.WriteLine(result);

// Console.WriteLine(Range(quarter));