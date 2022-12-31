// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FromOneToNumber(int number)
{
    if (number < 1) return -1;
    if (number == 1) return 1;
    Console.Write(FromOneToNumber(number - 1) + " ");
    return number;
}

int number = ReadNumber("Введи число: ");
Console.Write(FromOneToNumber(number));