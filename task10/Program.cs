// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 1000 % 10 > 0 || number / 100 % 10 == 0)
{
    Console.WriteLine("Число не является трехзначным");
}
else
{
    number = number / 10 % 10;
    Console.WriteLine(number);
}