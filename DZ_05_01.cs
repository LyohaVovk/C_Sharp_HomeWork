// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int [] GetNewArray(int size)
{
    return new int[size];
}

int [] FillArray(int [] array, int minValueArr, int maxValueArr)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValueArr, maxValueArr);

    return array;  
}

int GetEven(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++; 
    }
    return count;
}

int arrSize = GetNumber("Введите размер массива: ");
int [] array = GetNewArray(arrSize);
int [] threeDigitArr = FillArray(array, 100, 1000);
int evenCount = GetEven(threeDigitArr);
Console.Write("В массиве => ");
for(int i = 0; i < threeDigitArr.Length; i++)
    Console.Write($"{threeDigitArr[i]}, ");
Console.WriteLine("");
Console.WriteLine($"{evenCount} положительных чисел!");