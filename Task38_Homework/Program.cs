// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        difference = max - min;
    }
    return difference;
}

double[] arr = CreateArrayRndDouble(5, -7, 19);
PrintArray(arr);
double res = DifferenceMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(res, 1)}");
