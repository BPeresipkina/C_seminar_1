// Напиши программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток " + result);
}