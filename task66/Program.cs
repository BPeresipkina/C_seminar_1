// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromMToN(int M, int N)
{
    if (N < M) return -1;
    if (N == M) return M;
    return N + SumFromMToN(M, N - 1);
}

int m = ReadNumber("Введи число M: ");
int n = ReadNumber("Введи число N: ");
Console.Write(SumFromMToN(m,n));