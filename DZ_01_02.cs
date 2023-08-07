/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Найдем максимальное из трех введенных чисел!");
Console.WriteLine("Введите первое число: ");
int iFirstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int iSecondNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int iThirdNumber = int.Parse(Console.ReadLine()!);

if (iFirstNumber > iSecondNumber)
{
    if (iFirstNumber > iThirdNumber)
        Console.WriteLine($"Число {iFirstNumber} большее из трех введенных чисел!");
    else
        Console.WriteLine($"Число {iThirdNumber} большее из трех введенных чисел!");
}   
else
{
    if (iSecondNumber > iThirdNumber)
        Console.WriteLine($"Число {iSecondNumber} большее из трех введенных чисел!");
    else
        Console.WriteLine($"Число {iThirdNumber} большее из трех введенных чисел!"); 
}