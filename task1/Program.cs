// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    System.Console.Write("Большее число: " + A);
}
else if (A < B)
{
    System.Console.Write("Большее число: " + B);
}
else
{
    System.Console.Write("Числа равны");
}