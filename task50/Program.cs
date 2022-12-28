// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// ​5 9 2 3
// ​8 4 2 4

// ​1 7 -> такого числа в массиве нет

int[,] GetRandomArray(int line, int column, int min = -10, int max = 10)
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

//Random rand = new Random();
int line = 3;//rand.Next(2, 11);
int column = 4;//rand.Next(2, 11);

int[,] massiv = GetRandomArray(line, column);

int lineUser = ReadNumber("Введи номер строки: ");
int columnUser = ReadNumber("Введи номер столбца: ");

Console.WriteLine();
PrintArray(massiv);
Console.WriteLine();

if (lineUser > massiv.GetLength(0) || columnUser > massiv.GetLength(1))
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    int result = massiv[lineUser - 1, columnUser - 1];
    Console.WriteLine(result);
}