// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetRandomArray(int line, int column, int min = 0, int max = 10)
{
    int[,] array = new int[line, column];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int line = ReadNumber("Введи кол-во строк: ");
int column = ReadNumber("Введи кол-во столбцов: ");
int min = ReadNumber("Введи минимльное число массива: ");
int max = ReadNumber("Введи максимальное число в массиве: ");

int[,] massiv = GetRandomArray(line, column, min, max);

PrintArray(massiv);