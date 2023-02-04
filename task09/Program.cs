// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int InputN(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputN("введите x1 ");
int y1 = InputN("введите y1 ");
int z1 = InputN("введите z1 ");
int x2 = InputN("введите x2 ");
int y2 = InputN("введите y2 ");
int z2 = InputN("введите z2 ");

System.Console.Write(Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2)),2));