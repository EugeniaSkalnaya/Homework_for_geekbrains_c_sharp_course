// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
int Akk = Akkerman(M,N);
Console.Write($"Функция Аккермана = {Akk}");