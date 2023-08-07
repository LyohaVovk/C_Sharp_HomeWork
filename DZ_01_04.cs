/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите любое целое, положительное число: ");
int iAnyNumber = int.Parse(Console.ReadLine()!);
int iCounter = 1;
while (iCounter <= iAnyNumber)
{
    if (iCounter % 2 == 0)
    {
        Console.WriteLine(iCounter);
        iCounter++;
    }
    else
        iCounter++;
}