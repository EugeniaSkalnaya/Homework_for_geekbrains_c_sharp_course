﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
System.Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if ( N>=100 && N < 1000) //проверка на трехзначность
{
    System.Console.WriteLine($"Вторая цифра вашего числа: {N % 100 /10}" );
}
else
{
    System.Console.WriteLine("Трехзначное число состоит из трех цифр, попробуй еще раз");
}