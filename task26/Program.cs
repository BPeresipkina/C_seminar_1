// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadToInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetCountOfNumber(int number)
{
    // int div = 10;
    // int i = 1;
    // while (number / div > 0)
    // {
    //     div = div * 10;
    //     i++;
    // }
    // return i;
    if (number == 0) return 1;
    int count = 0;
    while(number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int number = ReadToInt("Введи число: ");
int count = GetCountOfNumber(number);

Console.WriteLine(count);