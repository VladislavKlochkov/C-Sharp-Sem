// Задача 33: 
// 1. Задайте массив. 
// 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find) return true;
    }
    return false;
}

bool FindNumber1(int[] array, int find)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            res = true;
            break;
        }
    }
    return res;
}

int[] arr = CreateArrayRndInt(10, -9, 9);
PrintArray(arr);
bool res = FindNumber(arr, 5);
Console.WriteLine(res ? "Да" : "Нет");

bool res1 = FindNumber1(arr, 5);
Console.WriteLine(res ? "Да" : "Нет");