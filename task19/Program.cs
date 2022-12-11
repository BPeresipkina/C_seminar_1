// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int divI = 10;
int i = 1;
while (number / divI > 0)
{
    divI = divI * 10;
    i++;
}
// Console.WriteLine(i);

int divJ = 10;
int j = 1;
int resultTop = number / (divI / 10);
int resultDown = number % divJ;

while (resultTop == resultDown && i >= j)
{
    divI = divI / 10;
    divJ = divJ * 10;
    i--;
    j++;
    resultTop = number / (divI / 10) % 10;
    resultDown = number % divJ / (divJ / 10);
}
if (i - j <= 1)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}