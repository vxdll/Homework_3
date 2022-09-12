//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату точки А по Х:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по Y:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по Z:");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по Х:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по Y:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по Z:");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"{result:f2}");