﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int num = int.Parse(number);
if (num < 100 || num > 999)
{
Console.Write($"Введенное число некорректно {num}");
}
else
{
int num2 = (num % 100) / 10;
Console.Write($"Вторая цифра числа {num2}");
}
