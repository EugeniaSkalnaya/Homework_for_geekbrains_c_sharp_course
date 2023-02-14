// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.WriteLine("Введите числа через пробел");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int PosiviteNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}


PrintArray(myArray);
int C = PosiviteNumbers(myArray);
System.Console.WriteLine($"{C}");