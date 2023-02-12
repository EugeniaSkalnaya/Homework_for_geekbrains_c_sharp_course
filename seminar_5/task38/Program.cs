// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] GenArray(int size)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(";", array) + "]");
}

double MinMaxDiff(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double result = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }

    return result = maxNumber - minNumber;
}

double[] myArray = GenArray(4);
PrintArray(myArray);
double Difference = MinMaxDiff(myArray);
System.Console.WriteLine($"разница между максимумом и минимумом равна - {Difference}");