// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNumber(string message)
{
    Console.Write(message);
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

int GetSumOdd(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2)
       sum += array[i];
    return sum;
}

int size = GetNumber("Введите размер массива: ");
int [] array = GetNewArray(size);
int [] newArr = FillArray(array, -100, 100);
int sumOdd = GetSumOdd(newArr);

Console.WriteLine("Сумма нечетных элементов массива ");
for(int i = 0; i < newArr.Length; i++)
    Console.Write($"{newArr[i]}, ");
Console.WriteLine($" => {sumOdd}");