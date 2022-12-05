//Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введи первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 & Num1 > Num3)
{
    Console.WriteLine("Наибольшее число: " + Num1);
}
else if (Num2 > Num3)
{
    Console.WriteLine("Наибольшее число: " + Num2);
}
else
{
    Console.WriteLine("Наибольшее число: " + Num3);
}