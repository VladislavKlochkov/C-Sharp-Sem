// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
    // 2 способ:
    // int sum = 0;
    // for (int i = 1; i < array.Length; i += 2)
    // {
    //     sum += array[i];
    // }
    // return sum;
}

int[] arr = CreateArrayRndInt(7, -19, 37);
PrintArray(arr);
int res = SumOfElementsInOddPositions(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");