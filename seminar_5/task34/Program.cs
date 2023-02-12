// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GenerateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int PositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter += 1;
        }
    }
    return counter;
}

int[] myArray = GenerateArray(15);
PrintArray(myArray);
int PositiveQuantity = (PositiveNumbers(myArray));
System.Console.WriteLine($"количество четных чисел равно - {PositiveQuantity}");