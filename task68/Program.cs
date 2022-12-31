// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

//          {n+1, if m==0;
// A(m,n)=  {A(m-1,1), if m!=0 && n=0;
//          {A(m-1,A(m,n-1)), if m>0, n>0;

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int result = Ackermann(2, 3);
Console.WriteLine(result);