// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// возвращает сумму от 1 до number
int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int A = ReadInt("Введите число: ");

int result = GetSumToNumber(A);

Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");