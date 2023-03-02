// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointB = Convert.ToInt32(Console.ReadLine());


double distan = DistanceBetweenPoints(xPointA, yPointA, zPointA, xPointB, yPointB, zPointB);

Console.WriteLine($"А ({xPointA}, {yPointA}, {zPointA}); B ({xPointB}, {yPointB}, {zPointB} -> {Math.Round(distan, 2, MidpointRounding.ToZero)}");

double DistanceBetweenPoints(int a1,int a2,int a3,int b1,int b2,int b3)
{
    double dist = Math.Sqrt(Math.Pow((b1-a1),2) + Math.Pow((b2-a2),2) + Math.Pow((b3-a3),2));
    return dist;
}