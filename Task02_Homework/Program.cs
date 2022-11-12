// Задача 2: Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} - большее, число {b} - меньшее");
}

else if (a < b)
{
    Console.WriteLine($"Число {b} - большее, число {a} - меньшее");
}

else Console.WriteLine("Среди введенных чисел нет большего и меньшего, так как они равны");