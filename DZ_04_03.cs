// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] InputArray(string message)
{
    int [] array = new int [8];
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine(message);
        array[i] = int.Parse(Console.ReadLine())!;
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array [i]} ");
    }
} 
int [] array = InputArray("Введите новый элемент массива: ");
PrintArray(array);