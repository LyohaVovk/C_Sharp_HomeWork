/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Функция ввода числа от пользователя
int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// Функция возвращающая истину, если заданный день 6 или 7
// и ложь, если другое число 
bool WeekEnd(int num)
{
    return num >= 6 && num < 8;
}

// Получаем число от пользователя
int dayOfWeek = InputNum("Введите число от 1 до 7, означающее день недели: ");
// Проверяем на принадлежность отрезку недели
if (dayOfWeek < 1 || dayOfWeek > 7)
    Console.WriteLine($"В неделе 7 дней, а не {dayOfWeek} :)");
else
{
    //вычисляем: выходной или нет и выводим результат
    if (WeekEnd(dayOfWeek))
        Console.WriteLine($"{dayOfWeek} день недели является выходным");
    else
        Console.WriteLine($"{dayOfWeek} день недели является рабочим");
}