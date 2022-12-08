// Задача 58: 
// 1. Задайте две матрицы. 
// 2. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(0); j++)
        {
            for (int m = 0; m < secondMatrix.GetLength(1); m++)
            {
                resMatrix[i, j] += firstMatrix[i, m] * secondMatrix[m, j];
            }
        }
    }
    return resMatrix;
}

int[,] array2D = CreateMatrixRndInt(2, 2, -10, 10);
int[,] arr2D = CreateMatrixRndInt(2, 2, -10, 10);
PrintMatrix(array2D);
Console.WriteLine($"{"x", 8}");
PrintMatrix(arr2D);
if (array2D.GetLength(1) == arr2D.GetLength(0))
{
    int[,] matrixMultiplication = MatrixMultiplication(array2D, arr2D);
    Console.WriteLine($"{"=", 8}");
    PrintMatrix(matrixMultiplication);
}
else Console.WriteLine($"Число столбцов первой матрицы не равняется числу строк второй матрицы. Умножение матриц не возможно");