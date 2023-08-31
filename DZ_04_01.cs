// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!); 
}

int firstNumber = GetNumber("Введите число, которое нужно возвести в степень: ");
int secondNumber = GetNumber("Задайте степень, в которую нужно возвести число: ");

int result = firstNumber;
if (result == 0)
    Console.WriteLine($"{firstNumber} в степени {secondNumber} = 0");
else if (result == 0)
    Console.WriteLine($"{firstNumber} в степени {secondNumber} = 1"); 
else
{
    
    for (int i = 2; i <= secondNumber; i++)
    {
        result *= firstNumber;
    }
}   
Console.WriteLine($"{firstNumber} в степени {secondNumber} = {result}");