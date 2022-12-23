// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfNumber(int number)
{
    if (number == 0) return 1;
    int count = 0;
    while (number != 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

int number = ReadNumber("Введи число: ");
int count = GetCountOfNumber(number);

// Console.WriteLine(count);

int[] array = new int[count];

for (int i = count - 1; i >= 0; i--)
{
    array[i] = number % 2;
    number /= 2;
}

Console.WriteLine(string.Join("", array));

// Метод решения с рекурсией от Ивана:

int num = 45;

void PrintBinaryView(int n)
{
    if (n <= 0) return;
    PrintBinaryView(n/2);
    Console.Write(n%2);
}

PrintBinaryView(num);