// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}