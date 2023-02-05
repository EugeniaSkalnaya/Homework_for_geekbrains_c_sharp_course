// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void PrintSquares(int N)
{
    for(int i=1; i<=N; i++)
    {
        System.Console.Write(Math.Pow(i, 3)+" ");
    }
}
int InputN(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int N = InputN("Введите число ");
PrintSquares(N);

