// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetRandomArray(int line = 4, int column = 4)
{
    int[,] array = new int[line, column];
    int n = 0;

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            n++;
            array[i, j] += n; //DOIT...
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

int[,] array = GetRandomArray();

Console.WriteLine();
PrintArray(array);