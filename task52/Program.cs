// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomArray(int line, int column, int min = 1, int max = 10)
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

int[,] massiv = GetRandomArray(line, column);

Console.WriteLine();
PrintArray(massiv);

Console.WriteLine();
double averageNumber = 0;
double sum = 0;
for (int j = 0; j < massiv.GetLength(1); j++)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sum += massiv[i, j];
    }
    averageNumber = sum / massiv.GetLength(0);
    Console.Write($"{averageNumber:f2} ");
    sum = 0;
}