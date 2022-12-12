// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// возвращает произведение от 1 до number
double GetProductToNumber(int number)
{
    double product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    return product;
}

int A = ReadInt("Введите число: ");

double result = GetProductToNumber(A);

Console.WriteLine($"Произведение чисел от 1 до {A} = {result}");