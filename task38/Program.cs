// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
int min = 1; //ReadNumber("Введи минимальное число в массиве: ");
int max = ReadNumber("введи максимальное число в массиве: ");

int[] array = Array(length, min, max);

Console.WriteLine(string.Join(", ", array));

int minNumber = array[0];
int maxNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    else if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

Console.WriteLine($"Максимальное число в массиве = {maxNumber}, минимальное число в массиве = {minNumber}");