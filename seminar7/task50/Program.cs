// Задача 50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Random rnd = new Random();
int rows = rnd.Next(2, 15);
int cols = rnd.Next(2, 15);

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 20);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t"); //красивая табуляция \t
        }
        System.Console.WriteLine();
    }
}

int RowPosition = ReadInt("введите номер строки в матрице: ");
int ColsPosition = ReadInt("введите номер столбца в матрице: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
printMatrix(myMatrix);

if (RowPosition < 0 || RowPosition > myMatrix.GetLength(0) - 1) Console.WriteLine("Нет такого элемента");
else if (ColsPosition < 0 || ColsPosition > myMatrix.GetLength(1) - 1) Console.WriteLine("Нет такого элемента");
else System.Console.WriteLine($"значение элемента матрицы: {myMatrix[RowPosition-1, ColsPosition-1]}");