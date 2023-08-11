﻿/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

// Функция выделения второй цифры из 4-значного числа
int pushSecondDigit (int num)
{
    // Отделяем от числа вторую и третью цыфры
    int secondDigit = num % 100;
    // отделяем и возвращаем 2 цифру
    return secondDigit / 10;
}

// Создаем случайное число при помощи функции генератора Random().New()
int randomNumber = new Random().Next (100, 1000);
// Присваиваем значение функции новой переменной
int pushDigit = pushSecondDigit(randomNumber);
// Выводим результат сгенерированного числа и функции получения второй его цифры
Console.WriteLine ($"Вторая цифра числа {randomNumber} равна {pushDigit}");