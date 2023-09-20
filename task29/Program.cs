﻿/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

//Ввод числа с экрана
int Prompt(string message)
{
    System.Console.Write(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //Приводим к числу
    return result; //вовзращаем результат
}
//Метод для получения случайных значений массива 
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; //Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1); //Заполняем случайными цифрами из диапозона SatrArr до EndArr
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); //Вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); //Вывод значения массива
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max); //Заполнение массива случайными числами
PrintArray(array); //Вывод массива
