// double res = Math.Sqrt(x);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки ");
Console.Write ("x: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write ("y: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write ("x: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write ("y: ");
double by = Convert.ToDouble(Console.ReadLine());


double Result (double ax1, double ay1, double bx1, double by1)
{
    return Math.Sqrt((ax1 - bx1)*(ax1 - bx1) + (ay1 - by1)*(ay1 - by1));
}
double result = Result (ax, ay, bx, by);
Console.WriteLine(Math.Round (result,2, MidpointRounding.ToZero));
