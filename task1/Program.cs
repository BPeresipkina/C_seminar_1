//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Например:
//a = 25, b = 5 -> Yes
//a = 2, b = 10 -> No
//a = 9, b = 3 -> Yes
//a = -3, b = 9 -> No

Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == (number2 * number2))
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
