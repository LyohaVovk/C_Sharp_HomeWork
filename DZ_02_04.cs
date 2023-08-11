/*
Программа на вход получает натуральное число. 
Необходимо его преобразовать таким образом, чтобы все нечетные числа стояли впереди, а все четные позади. 
При этом внутри четных и нечетных чисел очередность должна сохраняться. Результатом должно быть новое число, 
а не просто вывод на печать цифр в нужном порядке. 
Использовать можно только арифметические действия без работы со строкой.
Пример:
12345 -> 13524
3658563 -> 3553686
48 -> 48
5497 -> 5974
*/

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// Функция определения количества цифр в числе
int NumberOfDigits(int num)
{
    int digits = 0;
    switch (num)
    {
        case < 100:
            digits = 2;
            break;
        case < 1000:
            digits = 3;
            break;
        case < 10000:
            digits = 4;
            break;
        case < 100000:
            digits = 5;
            break;
        case < 1000000:
            digits = 6;
            break;
    }
    return digits;
}

int PushZero(int num)
{
    while (num % 10 == 0)
    {
        num = num / 10;
    }
    return num;
}

int numToDivide = InputNum("Введите число от 10 до 1000000: ");
int quantity = NumberOfDigits(numToDivide);
Console.WriteLine($"Количество цифр в числе {numToDivide} => {quantity}");

int evenNumber = 0;
int oddNumber = 0;
int intResult = 0;
int evenDegree = 0;
int oddDegree = 0;

while(quantity > 0)
{
    intResult = numToDivide / (int)Math.Pow(10, quantity - 1);
    if (intResult % 2 == 0)
    {
        if (evenNumber == 0)
        {
            evenNumber = evenNumber + intResult * (int)Math.Pow(10, quantity - 1);
            evenDegree = quantity - 1;
        } 
        else
        {
            evenNumber = evenNumber + intResult * (int)Math.Pow(10, evenDegree - 1);
            evenDegree--;
        }

    }
    else
        if (oddNumber == 0)
        {
            oddNumber = oddNumber + intResult * (int)Math.Pow(10, quantity - 1);
            oddDegree = quantity - 1;
        }
        else
        {
            oddNumber = oddNumber + intResult * (int)Math.Pow(10, oddDegree - 1);
            oddDegree--;
        }
    
    numToDivide = numToDivide % (int)Math.Pow(10, quantity - 1);
    quantity--;
    
}

int evenWithoutZero = PushZero(evenNumber);
int oddWithoutZero = PushZero(oddNumber);
int evenQuantity = NumberOfDigits(evenWithoutZero);
int convNumber = oddWithoutZero * (int)Math.Pow(10, evenQuantity) + evenWithoutZero;

Console.WriteLine($"Четное число => {evenNumber}, нечетное число => {oddNumber}");
Console.WriteLine($"Преобразованное Четное число => {evenWithoutZero}, преобразованное нечетное число => {oddWithoutZero}");
Console.WriteLine($"Преобразованное число => {convNumber}");