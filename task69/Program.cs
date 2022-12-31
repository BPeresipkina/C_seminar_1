// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int RaisingMToPowerN(int M, int N)
{
    if (N < 0) return -1;
    if (N == 0) return 1;
    return M * RaisingMToPowerN(M, N-1);
}

int m = ReadNumber("Введи число M: ");
int n = ReadNumber("Введи число N: ");
Console.Write(RaisingMToPowerN(m,n));