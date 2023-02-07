//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PowElements(int A, int B)
{
    int result = 1;

    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
return result;
}

int Num = GetNumber("Введите число А");
int NumPow = GetNumber("Введите число для обозначения степени");

System.Console.WriteLine($"Число {Num} в степени {NumPow} равно {PowElements(Num, NumPow)}");
