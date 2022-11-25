// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. 
// 2. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplicationArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;
    int[] multiplicationArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        multiplicationArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) multiplicationArray[size - 1] = array[size - 1];
    return multiplicationArray;
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
int[] res = MultiplicationArray(arr);
PrintArray(res);