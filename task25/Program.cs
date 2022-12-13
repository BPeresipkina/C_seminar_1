// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double AToPowerB(int A, int B)
{
    double result = 1;
    while (B > 0)
    {
        result = result * A;
        B--;
    }
    return result;
}

int A = ReadNumber("Введите первое число: ");
int B = ReadNumber("Введите второе число: ");

if (B > 0)
{
    double result = AToPowerB(A, B);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Степень отрицательная");
}