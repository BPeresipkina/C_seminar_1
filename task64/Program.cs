// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FromNumberToOne(int number, int m = 1)
{
    if (number < 1) return -1;
    if (m == number) return number;
    Console.Write(FromNumberToOne(number, m + 1) + " ");
    return m;
}

int number = ReadNumber("Введи число: ");
Console.Write(FromNumberToOne(number));