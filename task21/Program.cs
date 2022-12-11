// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введи координату X для точки A");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи координату Y для точки A");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи коодринату Z для точки A");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи координату X для точки B");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи координату Y для точки B");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи коодринату Z для точки B");
int Zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Xb - Xa,2) + Math.Pow(Yb - Ya,2) + Math.Pow(Zb - Za,2));
Console.WriteLine($"{result:f2}");