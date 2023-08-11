/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// Функция ввода числа от пользователя
int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// Функция выделения 3 цифры из заданного числа
void ThirdPushDigit(int num)
{
    switch (num)
    {
        // Если число меньше 100
        case < 100:
            // Выводим сообщение
            Console.WriteLine($"Число {num} не имеет третьей цифры");
            break;
            // если больше вычисляем и выводим
        case < 1000:
            Console.WriteLine($"Третья цифра в числе {num} => {num % 10}");
            break;
        case < 10000:
            Console.WriteLine($"Третья цифра в числе {num} => {num % 100 / 10}");
            break;
        case < 100000:
            Console.WriteLine($"Третья цифра в числе {num} => {num % 1000 / 100}");
            break;
    }
}

// Получаем число от пользователя
int specifiedNumber = InputNum("Введите члюбое число от 0 до 100000: ");
// Выводит результат работы функции
ThirdPushDigit(specifiedNumber);