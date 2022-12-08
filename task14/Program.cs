// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int krat1 = 7;
int krat2 = 23;

if ((number % krat1 == 0)&&(number % krat2 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}