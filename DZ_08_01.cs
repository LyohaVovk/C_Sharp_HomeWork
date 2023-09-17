// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int [,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    int [,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] SortedMatrix(int [,] matrix)
{
    int sortedSize = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < sortedSize; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }    
    }
    return matrix;
}

int rows = GetNumber("Input rows quantity: ");
int columns = GetNumber("Input columns quantity: ");
int min = GetNumber("Input min range: ");
int max = GetNumber("Input max range: ");
int [,] matrix = CreateRandomMatrix(rows, columns, min, max);

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortedMatrix(matrix));