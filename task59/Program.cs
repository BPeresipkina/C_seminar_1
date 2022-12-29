// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int min = array[0, 0];
int iMin = 0;
int jMin = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (min > array[i, j])
        {
            min = array[i, j];
            iMin = i;
            jMin = j;
        }
    }
}

Console.WriteLine($"{min}, {iMin}, {jMin}");
Console.WriteLine();

int[,] massiv = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
int lineOffset = 0;
int columnOffset = 0;

for (int i = 0; i < massiv.GetLength(0); i++)
{
    if (i == iMin) lineOffset = 1;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        if (j == jMin) columnOffset = 1;
        massiv[i,j] = array[i+lineOffset,j+columnOffset];
    }
    columnOffset = 0;
}

// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     if (i >= iMin)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             if (j >= jMin)
//             {
//                 massiv[i, j] = array[i + 1, j + 1];
//             }
//             else
//             {
//                 massiv[i, j] = array[i + 1, j];
//             }
//         }
//     }
//     else
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             if (j >= jMin)
//             {
//                 massiv[i, j] = array[i, j + 1];
//             }
//             else
//             {
//                 massiv[i, j] = array[i, j];
//             }
//         }
//     }
// }

PrintArray(massiv);