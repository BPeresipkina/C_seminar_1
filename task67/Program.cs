// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumNumber(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNumber(number / 10);
}

int number = ReadNumber("Введи число: ");
Console.Write(SumNumber(number));