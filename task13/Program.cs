// Напишите программу, которая задаёт массив из N элементов и выводит их на экран,
// где пользователь задает левую и правую границы массива
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    //  int count = array.Length;
    // for (int i = 0; i < 1; i++)
    // {
    // System.Console.Write($"{array[i]} ");
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    // }
}

int size = GetNumber("Введите размер массива: ");
int leftEdge = GetNumber("Введите левую границу массива: ");
int rightEdge = GetNumber("Введите правую границу массива: ");

if (leftEdge <= rightEdge)
{
    int[] FillArray()
    {
        int[] arrN = new int[size];
        for (int i = 0; i < size; i++)
        {
            arrN[i] = new Random().Next(leftEdge, rightEdge);
        }
        return arrN;
    }

    int[] myArray = FillArray();
    PrintArray(myArray);
}
else
{
    System.Console.Write("Левая граница должна быть меньше правой, попробуй еще раз");
}