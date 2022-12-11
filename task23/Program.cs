// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; N >= i; i++)
{
double result = Math.Pow(i, 3);
Console.Write(result + " ");
}