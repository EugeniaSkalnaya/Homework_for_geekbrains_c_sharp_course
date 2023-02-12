// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] GenerateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(0,20);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int OddSum(int[] array)
{
    int oddsum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            oddsum += array[i];
        }
    }
    return oddsum;
}

int[] myArray = GenerateArray(7);
PrintArray(myArray);
int Odd_Sum = (OddSum(myArray));
System.Console.WriteLine($"сумма нечетных элементов равна - {Odd_Sum}");