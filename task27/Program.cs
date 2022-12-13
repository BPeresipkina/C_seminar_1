// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfComponents(int number)
{
    int i = 0;
    int n = number;
    while (n != 0)
    {
        n /= 10;
        i++;
    }
    int result = 0;
    int div = 10;
    while (i > 0)
    {
        result = result + number % div / (div / 10);
        div *= 10;
        i--;
    }
    return result;
}

int result = SumOfComponents(number);
Console.WriteLine(result);