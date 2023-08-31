// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int CountDigit(int number) 
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int SumOfDigits(int number, int countDigit)
{
    int sum = 0;
    for(int i = 0; i <= countDigit; i++)
    {
        sum += (number % 10);
        number /= 10;
    }
    return sum;
}

int num = GetNumber("Введите число");
int sum = SumOfDigits(num, CountDigit(num));
Console.WriteLine($"Сумма цифр числа {num} => {sum}");