/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Давайте сравним два числа!");
Console.WriteLine("Введите первое число: ");
int iFirstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int iSecondNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Теперь сравним эти числа!");
Console.WriteLine("Нажмите любую клавишу для продолжения: ");
Console.ReadLine();
if (iFirstNumber > iSecondNumber)
    Console.WriteLine($"Число {iFirstNumber} больше, чем число {iSecondNumber}");
else
    Console.WriteLine($"Число {iSecondNumber} больше, чем число {iFirstNumber}");

Console.WriteLine("Спасибо за внимание :)");