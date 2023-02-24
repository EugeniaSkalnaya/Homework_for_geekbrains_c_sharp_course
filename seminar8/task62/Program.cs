// Задача 62: Заполните спирально массив.
// 1   2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SquareMatrix(int rows, int cols)
{

    int[,] squareMatrix = new int[rows, cols];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
    {
        squareMatrix[i, j] = temp;
        if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
        temp++;
    }
    return squareMatrix;
}
int rows = ReadInt("введите количество строк в матрице: ");
int cols = ReadInt("введите количество столбцов матрицы: ");

var myMatrix = SquareMatrix(rows, cols);
PrintMatrix(myMatrix);