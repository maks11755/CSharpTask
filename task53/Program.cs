// task53. Задайте двумерный массивю
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];
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
        // Console.Write("[);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        // Console.WriteLine("]);
        Console.WriteLine();
    }
}

void ReplacementSeats (int [,] matrix)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[0, j];
            matrix[0 , j] = matrix[matrix.GetLength(0) - 1,  j];
            matrix[matrix.GetLength(0) - 1,  j] = temp;
        }
}

//{
// int firstRow = 0;
// int lastRow = matrix.GetLendth(0) - 1;
// for (int j = 0; j < matrix. Getlength(1); j++)
// {
//       int temp = matrix[firstRow, j];   
//       matrix[firstRow, j] = matrix[lastRow, j];
//       matrix[lastRow, j] = temp;
// }
// }
int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(createMatrixRndInt);
Console.WriteLine();
ReplacementSeats(createMatrixRndInt);
PrintMatrix(createMatrixRndInt);