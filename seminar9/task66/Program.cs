// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число первое число N: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второе число M: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumSum(int numM, int numN, int sum)
{
  if (numN < numM)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  NumSum(numM, numN - 1, sum+numN);
}

NumSum(M,N,0);