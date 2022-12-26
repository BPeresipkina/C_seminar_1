// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​m = 3, n = 4.

// 0,5   7     -2     -0,2
// ​1    -3,3    8     -9,9
// ​8     7,8   -7,1    9

double[,] GetRandomArray(int line, int column, int min = 0, int max = 10)
{
    double[,] array = new double[line, column];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(min, max + 1) + rand.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2} ");
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

double[,] massiv = GetRandomArray(line, column);
Console.WriteLine();
PrintArray(massiv);