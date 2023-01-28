// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите число В: ");
int B = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите число С: ");
int C = Convert.ToInt32 (Console.ReadLine());
if (A>B && A>C)
{
    System.Console.Write("Максимальное число: " + A);
}
else if (C>A && C>B)
{
    System.Console.Write("Максимальное число: " + C);
}
else if (B>A && B>C)
{
    System.Console.Write("Максимальное число: " + B);
}