// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
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

int[] FindMinElementPosition(int[,] matrix)
{
    int[] rowColumn = new int[2];
    int minElement = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                rowColumn[0] = i;
                rowColumn[1] = j;
            }
        }
    }
    return rowColumn;
}

int[,] DeleteRowColumn(int[,] matrix, int[] index)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == index[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == index[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatrix;
}


int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
int[] findMinElementPosition = FindMinElementPosition(array2D);
int[,] deleteRowColumn = DeleteRowColumn(array2D, findMinElementPosition);
Console.WriteLine();
PrintMatrix(deleteRowColumn);

// int[,,] CreateMatrixRndInt1(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) //2
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1); // 2- 3
//             }

//         }
//     }
//     return matrix;
// }