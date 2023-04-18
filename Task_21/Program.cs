//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.WriteLine("Введите координат X1: ");
int X1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координат Y1: ");
int Y1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координат Z1: ");
int Z1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координат X2: ");
int X2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координат Y2: ");
int Y2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координат Z2: ");
int Z2 = int.Parse(Console.ReadLine() ?? "");

double distance = GetDistance(X1, Y1, Z1, X2, Y2, Z2);

static double GetDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    int deltaX = X2 - X1;
    int deltaY = Y2 - Y1;
    int deltaZ = Z2 - Z1;
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distance;
}

Console.WriteLine(distance);