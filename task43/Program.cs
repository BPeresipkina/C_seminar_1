// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = ReadNumber("Введи b1: ");
double k1 = ReadNumber("Введи k1: ");
double b2 = ReadNumber("Введи b2: ");
double k2 = ReadNumber("Введи k2: ");

double x = (b1 - b2)/(k2 - k1);
if (k1 * x + b1 == k2 * x + b2)
{
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 имеет координаты X = {x:f2}, Y = {y:f2}");
}
else Console.WriteLine("Формула для X выведена неверно!!!");

