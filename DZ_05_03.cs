// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double [] FillDoubleArr(int size, int maxValue)
{
    double [] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(rnd.NextDouble() * maxValue, 2);
    return arr;    
}

int size = GetNumber("Введите размер массива: ");
double [] realArr = FillDoubleArr(size, 100);
double min = realArr[0];
double max = realArr[0];
for (int i = 0; i < realArr.Length; i++)
{
    if (realArr[i] < min)
        min = realArr[i];
    else if (realArr[i] > max)
        max = realArr[i];
} 
Console.Write($"В массиве ");
for(int i = 0; i < realArr.Length; i++)
     Console.Write($" {realArr[i]}");
Console.WriteLine(";");
Console.WriteLine($"разница между максимальным и минимальным: {max} - {min} => {max - min}");