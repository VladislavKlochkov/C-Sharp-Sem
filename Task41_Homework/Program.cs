// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите общее количество чисел:");
int m = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число под индексом {i}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int positiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveNumber++;
    }
    return positiveNumber;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

if (m > 0)
{
    int[] arr = CreateArray(m);
    PrintArray(arr);
    int res = PositiveNumbers(arr);
    Console.WriteLine($"Количество чисел больше 0 -> {res} ");
}
else Console.WriteLine("Введите число больше нуля");