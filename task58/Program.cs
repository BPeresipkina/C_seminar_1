// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] ProductOfTwoArray(int[,] array1, int[,] array2)
{
    int row = 0;
    int column = 0;
    int rowMin = 0;
    int columnMin = 0;
    if (array1.GetLength(0) > array2.GetLength(0))
    {
        row = array1.GetLength(0);
        rowMin = array2.GetLength(0);
    }
    else 
    { 
        row = array2.GetLength(0); 
        rowMin = array1.GetLength(0);
    }

    if (array1.GetLength(1) > array2.GetLength(1))
    { 
        column = array1.GetLength(1); 
        columnMin = array2.GetLength(1);
    }
    else 
    { 
        column = array2.GetLength(1); 
        columnMin = array1.GetLength(1);
    }

    int[,] productArray = new int[row, column];
    for (int i = 0; i < rowMin; i++)
    {
        for (int j = 0; j < columnMin; j++)
        {
            productArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return productArray;
}

int line1 = ReadNumber("Введи кол-во строк 1й матрицы: ");
int column1 = ReadNumber("Введи кол-во столбцов 1й матрицы: ");
int line2 = ReadNumber("Введи кол-во строк 2й матрицы: ");
int column2 = ReadNumber("Введи кол-во столбцов 2й матрицы: ");

int[,] array1 = GetRandomArray(line1, column1);
int[,] array2 = GetRandomArray(line2, column2);

Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] productArray = ProductOfTwoArray(array1, array2);
PrintArray(productArray);