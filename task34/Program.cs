// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int length = ReadNumber("Введи длину массива: ");
int min = 100; //ReadNumber("Введи минимальное число в масиве: ");
int max = 999; //ReadNumber("Введи максимальное число в массиве: ");

int[] array = Array(length, min, max);

Console.WriteLine(string.Join(", ", array));

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        j++;
    }
}
if (j == 0)
{
    Console.WriteLine("Четных чисел в массиве нет");
}
else
{
    Console.WriteLine($"Количество четных чисел в массиве = {j}");
}