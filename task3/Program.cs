// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 2 == 0)
{
    System.Console.Write("Число четное");
}
else
{
    System.Console.Write("Число не четное");
}
