/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Давайте проверим четное число или нет? ");
Console.WriteLine("Введите любое целое число: ");
int iEvenNumber = int.Parse(Console.ReadLine()!);

if (iEvenNumber % 2 == 0) 
    Console.WriteLine($"Число {iEvenNumber} является четным.");
else
    Console.WriteLine($"Число {iEvenNumber} является нечетным.");