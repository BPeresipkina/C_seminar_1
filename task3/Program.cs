﻿//Напишите программу, которая будет выдавать название для недели по заданному номеру
//Например:
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введи номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Такого дня недели не существует");
