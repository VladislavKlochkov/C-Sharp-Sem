// Задача 57: 
// 1. Составить частотный словарь элементов двумерного массива. 
// 2. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i,j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4}; ");
        else Console.Write($"{array[i],4} ");
    }
    Console.Write("|");
}

void FindClone (int[]array)
{
    int number = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count ++;
        else
        {
            Console.WriteLine($"Число {number} встречается {count} раз(а)");
            number = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {number} встречается {count} раз(а)");
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int[] newArr = MatrixToArray(array2D);
Console.WriteLine();
Array.Sort(newArr);
PrintArray(newArr);
Console.WriteLine();
FindClone(newArr);