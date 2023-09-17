// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool SwapNum(int num1, int num2)
{
    return num2 > num1;
}

int SumNumbers(int m, int n)
{
    int sum = 0;
    if (SwapNum(m, n)) for (int i = m; i <= n; i++) sum += i;
    else for (int i = n; i <= m; i++) sum += i;
    return sum;
}

Console.Clear();
int firstNum = GetNumber("Введите первое число: ");
int secondNum = GetNumber("Введите второе число: ");
int sum = SumNumbers(firstNum, secondNum);
Console.WriteLine($"Сумма чисел между {firstNum} и {secondNum} => {sum}");