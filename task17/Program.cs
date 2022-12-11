// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введи координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка в 1й координатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка во 2й координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка в 3й координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка в 4й координатной четверти");
}
else
{
    Console.WriteLine("Невозможно определить четверть");
}