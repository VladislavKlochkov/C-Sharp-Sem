// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же 
// 3. указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента в двумерном массиве");
Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

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

bool FindElements(int[,] matrix, int m, int n)
{
    return m < matrix.GetLength(0) && n < matrix.GetLength(1) && m + 1 > 0 && n + 1 > 0;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

bool res = FindElements(array2D, m, n);
Console.WriteLine(res ? $"Элемент с индексами ({m},{n}) -> {array2D[m, n]}" : $"Элемента с индексами ({m},{n}) нет");