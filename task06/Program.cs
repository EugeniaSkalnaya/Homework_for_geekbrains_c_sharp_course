﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Number = N;
if (N > 99 || N < -99)
{
    while (N > 999 || N < -999)
    {
        N = N / 10;
    }
    System.Console.WriteLine($"Третья цифра этого числа - это {Math.Abs(N % 10)}");
}
else
{
    System.Console.WriteLine("В этом числе нет третьей цифры, введите другое число");
}