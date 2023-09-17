// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] Create3DArray(int m, int n, int o)
{
    int [,,] arr3d = new int[m, n, o];
    Random rand = new Random((int)(DateTime.Now.Ticks));
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                arr3d[i, j, k] = rand.Next(0, 100);
                if (arr3d[i, j, k] < 10)
                    arr3d[i, j, k] *= 10;
            }
        }
    }
    return arr3d;
}

void Print3DArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i + 1}-й слой");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

int [,,] arr3D = Create3DArray(3, 3, 3);
Print3DArray(arr3D);