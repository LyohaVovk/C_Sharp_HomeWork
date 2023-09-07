// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int PosQuantityNum(int number)
{
     int result = 0;
     int count = 1;
     while (count <= number)
    {
        int num = GetNumber($"Введите {count} число: ");
        if (num > 0)
            result++;
        count++;    
    }
    return result;
}

int result = PosQuantityNum(GetNumber("Введите количество задаваемых чисел: "));
Console.WriteLine($"Вы ввели {result} положительных чисел");