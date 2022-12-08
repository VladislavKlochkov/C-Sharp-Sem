// Задача 60.
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt1(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = number++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4}({i}, {j}, {k}), ");
                else Console.Write($"{matrix[i, j, k],4}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = CreateMatrixRndInt1(2, 2, 2);
PrintMatrix(array3D);

// int[,,] CreateMatrixRndInt1(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth];
//     Random rnd = new Random();
//     int number = rnd.Next(min, max + 1);
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 if (RepeatingNumber(matrix, number) == false)
//                 {
//                     matrix[i, j, k] = number;
//                 }
//                 number = rnd.Next(min, max + 1);
//             }
//         }
//     }
//     return matrix;
// }

// bool RepeatingNumber(int[,,] matrix, int number)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 if (matrix[i, j, k] == number) return true;
//             }
//         }
//     }
//     return false;
// }