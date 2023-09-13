// task59. Задайте двумерный массив из целых чиселю         1 4 7 2        9 2 3
// Напишите программу, которая удалит строку и столбец,     5 9 2 3        4 2 4 
// на пересечении которых расположен наименьший             8 4 2 4        2 6 7 
// элемент массива.                                         5 2 6 7

// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// }
// }
// }

// void printm(int[,] array)
// {
// int i,j;
// for (i = 0; i < array.GetLength(0); i++)
// {
// Console.WriteLine();
// for (j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }
// }

// mas(m,n);
// Console.WriteLine("nИсходный массив: ");
// printm(randomArray);

// // Функция, считающая сумму элементов в строке
// int SumLine(int[,] array, int i)
// {
// int sum = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
// {
// sum += array[i,j];
// }
// return sum;
// }

// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
// if (sum > SumLine(randomArray, i))
// {
// sum = SumLine(randomArray, i);
// minSum = i+1;
// }
// }
// Console.WriteLine($"n Строка c наименьшей суммой элементов:  {minSum}");


// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int[,] positionSmallElement = new int[1, 2];
// positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
// Console.Write($"Позиция элемента: \n");
// WriteArray(positionSmallElement);

// int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// DeleteLines(array, positionSmallElement, arrayWithoutLines);
// Console.WriteLine($"\nПолучившийся массив:");
// WriteArray(arrayWithoutLines);


// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FindPositionSmallElement(int[,] array, int[,] position)
// {
//   int temp = array[0, 0];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] <= temp)
//       {
//         position[0, 0] = i;
//         position[0, 1] = j;
//         temp = array[i, j];
//       }
//     }
//   }
//   Console.WriteLine($"\nMинимальный элемент: {temp}");
//   return position;
// }

// void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
// {
//   int k = 0, l = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
//       {
//         arrayWithoutLines[k, l] = array[i, j];
//         l++;
//       }
//     }
//     l = 0;
//     if (positionSmallElement[0, 0] != i)
//     {
//       k++;
//     }
//   }
// }

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
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j],5}");
}
Console.WriteLine();
}
}

int[] MinElementIndexes(int[,] matrix)
{
int minElemRow = 0;
int minElemColumn = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] < matrix[minElemRow, minElemColumn])
{
minElemRow = i;
minElemColumn = j;
}
}
}
return new int[] { minElemRow, minElemColumn };
}

int[,] NewMatrixDeleteMinElemIndexes(int[,] matrix, int delRow, int delCol)
{
int m = 0, n = 0;
int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
n = 0;
if (m == delRow) m = m + 1; //m++; // пропуск строки
for (int j = 0; j < newMatrix.GetLength(1); j++)
{
if (n == delCol) n = n + 1; //n++; // пропуск столбца
newMatrix[i, j] = matrix[m, n];
n++;
}
m++;
}
return newMatrix;
}


int[,] array2d = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(array2d);
Console.WriteLine();
int[] minElementIndexes = MinElementIndexes (array2d);
int[,] newMatrixDeleteMinElemIndexes = NewMatrixDeleteMinElemIndexes(array2d, minElementIndexes[0], minElementIndexes[1]);
Console.WriteLine();
PrintMatrix(newMatrixDeleteMinElemIndexes);