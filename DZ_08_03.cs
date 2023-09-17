// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] PowMatrix(int [,] matrA, int [,] matrB)
{
    int sum = 0;
    int [,] resMatrix = new int[matrA.GetLength(0), matrA.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resMatrix.GetLength(0); k++)
                sum += matrA[i, k] * matrB[k, j];
            resMatrix[i, j] = sum;   
            sum = 0; 
        }
    }
    return resMatrix;
}

// int rows = GetNumber("Input rows quantity: ");
// int columns = GetNumber("Input columns quantity: ");
// int min = GetNumber("Input min range: ");
// int max = GetNumber("Input max range: ");
int [,] matrixA = CreateRandomMatrix(2, 2, 0, 2);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrixA);
Console.WriteLine();
int [,] matrixB = CreateRandomMatrix(2, 2, 0, 2);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrixB);
Console.WriteLine();
int [,] powMatrix = PowMatrix(matrixA, matrixB);
PrintMatrix(powMatrix);