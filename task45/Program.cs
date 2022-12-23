// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int length = ReadNumber("Введи длину массива: ");
int min = ReadNumber("Введи минимальное число в массиве: ");
int max = ReadNumber("введи максимальное число в массиве: ");

int[] array = Array(length, min, max);

Console.WriteLine();
Console.WriteLine(string.Join(", ", array));

int[] massiv = new int[length];

for(int i = 0; i<length; i++)
{
    massiv[i] = array[i];
}

array[2] = 999;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine(string.Join(", ", massiv));