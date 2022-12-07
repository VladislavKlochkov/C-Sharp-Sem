// Задача 55: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая заменяет строки на столбцы. 
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int[,] rowsToColumns = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsToColumns[i, j] = matrix[j, i];
        }
    }
    return rowsToColumns;
}

int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] replaceRowsToColumns = ReplaceRowsToColumns(array2D);
    PrintMatrix(replaceRowsToColumns);
}
else Console.WriteLine("Замена строк на столбцы не возможна");

// 2 способ

// void CreateNewMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = temp;
//         }
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
// PrintMatrix(array2D);
// Console.WriteLine();
// if (array2D.GetLength(0) != array2D.GetLength(1))
//     Console.WriteLine("перевернуть не возможно!");
// else
// {
//     CreateNewMatrix(array2D);
//     PrintMatrix(array2D);
// }