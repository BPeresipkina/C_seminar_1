// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintArrayAndSumLine(int[,] matr)
{
    int sum = 0;
    int sumMin = 999999;
    int line = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            Console.Write($"{matr[i, j]} ");
        }
        Console.Write($"Сумма строки = {sum}");
        if(sumMin>sum) 
        {
            sumMin = sum;
            line = i;
        }
        sum = 0;
        
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма в строке {line+1} = {sumMin}");
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
PrintArrayAndSumLine(array);
Console.WriteLine();