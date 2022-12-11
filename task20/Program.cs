// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X для точки A: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки A");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X для точки B");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B");
int Yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
Console.WriteLine($"{result:f2}");
