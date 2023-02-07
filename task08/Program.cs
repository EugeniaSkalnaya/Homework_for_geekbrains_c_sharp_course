// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число ");
string? Str = Console.ReadLine();
if (Str.Length == 5)
{
    if (Str[0] == Str[4] || Str[1] == Str[3])
    {
        System.Console.Write($"Ваше число: {Str} - палиндром.");
    }
    else System.Console.Write($"Ваше число: {Str} - не палиндром.");
}
else
{
    System.Console.Write("Введите все же пятизначное число ");
}