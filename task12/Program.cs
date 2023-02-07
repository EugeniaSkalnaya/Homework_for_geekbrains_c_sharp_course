//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int N)
{

    int counter = Convert.ToString(N).Length;
    int sum = 0;

    for (int i = 0; i < counter; i++)
    {
        sum += N % 10;
        N = N / 10;
    }
    return sum;
}

int SumFinal = SumNumber(GetNumber("Введите число "));
Console.Write("Сумма цифр в числе: " + SumFinal);