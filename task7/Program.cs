// Напишите программу, которая принимает на вход трехзнаное число и на выходе показывает последнюю цифру этого числа
//Например:
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int mod = number % 10;
Console.WriteLine(mod);
