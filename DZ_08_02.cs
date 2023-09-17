// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int GetNumber(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

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

int [] RowSum(int [,] matrix)
{
    int [] sumElem = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumElem[i] += matrix[i, j];
    }
    return sumElem;
}

void SmallestSum(int [] sumArray)
{
    int index = 0;
    int small = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < small)
        {
            small = sumArray[i];
            index = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов => {small} в строке {index + 1}");
}

int [,] matrix = CreateRandomMatrix(4, 4, 0, 10);
Console.WriteLine("Заданный массив:");
PrintMatrix(matrix);
Console.WriteLine();
int [] sumArray = RowSum(matrix);
Console.WriteLine("Сумма строк:");
for (int i = 0; i < sumArray.Length; i++) Console.WriteLine($"{sumArray[i]}");
Console.WriteLine();
SmallestSum(sumArray);