﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.Write("Введите число, обозначающее день недели ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 6 || N == 7)
{
    Console.Write("Да, этот день выходной");
}
else if (N < 1 || N > 7)
{
    Console.Write("Это не день недели!");
}
else Console.Write("Нет, этот день не выходной");
