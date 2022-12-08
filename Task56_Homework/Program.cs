// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementsOfRows(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElements += matrix[i, j];
        }
        sumArray[i] = sumElements;
    }
    return sumArray;
}

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4}; ");
        else Console.Write($"{array[i],4} ");
    }
    Console.WriteLine("|");
}

int RowsMinSum(int[] array)
{
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            row = i;
        }
    }
    return row;
}
int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int[] arr = SumElementsOfRows(array2D);
Console.WriteLine();
PrintArray(arr);
int rowsMinSum = RowsMinSum(arr);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов находится в(о) {rowsMinSum + 1} строке");