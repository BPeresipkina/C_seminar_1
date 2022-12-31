// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FromMToN(int M, int N)
{
    if (N < M) return -1;
    if (N == M) return M;
    Console.Write(FromMToN(M, N - 1) + " ");
    return N;
}

int m = ReadNumber("Введи число M: ");
int n = ReadNumber("Введи число N: ");
Console.Write(FromMToN(m,n));