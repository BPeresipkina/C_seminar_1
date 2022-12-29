// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] array = GetRandomArray(line, column);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();

int saveNumber = 0;
for(int j =0; j < array.GetLength(1); j++)
{
    saveNumber = array[0,j];
    array[0,j] = array[array.GetLength(0)-1, j];
    array[array.GetLength(0)-1, j] = saveNumber;
}

PrintArray(array);